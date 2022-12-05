using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using JavaScriptEngineSwitcher.V8;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;

using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.IdentityModel.Tokens.Jwt;
using IdentityModel.Client;
using System.Net.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using IdentityModel;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System.Security.Claims;
using Newtonsoft.Json;
using System.Security.Principal;
using Microsoft.AspNetCore.HttpOverrides;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH.Model;
using Microsoft.IdentityModel.Logging;
using static Configuracion.Instalador.Contexto;
using IST.RRHH.Domain.Jobs;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using IST.RRHH.Domain.Utilidades;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.AspNetCore.Mvc;

namespace IST.RRHH.Web
{
    public class Startup
    {
        //private string ConnectionString =  "Data Source=SQL5059.site4now.net;Initial Catalog=DB_A4663C_crm;User Id=DB_A4663C_crm_admin;Password=hola.2020";

        private Container container = new Container();


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddHttpsRedirection(options =>
            //{
            //    options.RedirectStatusCode = (int)HttpStatusCode.TemporaryRedirect;
            //    options.HttpsPort = 443;
            //});
            JwtSecurityTokenHandler.DefaultMapInboundClaims = false;

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddReact();

            IST.RRHH.Domain.Startup.ConnectionString = AppConfig.ConnectionString;

            // Make sure a JS engine is registered, or you will get an error!
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName)
                .AddV8();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("es-CL");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("es-CL") };
                options.RequestCultureProviders.Clear();
            });

            services.AddControllersWithViews(options =>
                options.Filters.Add(new RequireHttpsAttribute()));


            services.AddMvc();



            //services.AddScoped<IBDContext>(_ => new ContextExtended(AppConfig.ConnectionString));

            services.AddRazorPages().AddRazorRuntimeCompilation();


            //services.AddSingleton<IDiscoveryCache>(r =>
            //{
            //    var factory = r.GetRequiredService<IHttpClientFactory>();
            //    return new DiscoveryCache(AppConfig.UrlSSO, () => factory.CreateClient());
            //});

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IPrincipal>(
                provider => provider.GetService<IHttpContextAccessor>().HttpContext.User);

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = Configuracion.Instalador.Contexto.GetSSO() + "/";
                options.Audience = "api1";
                options.RequireHttpsMetadata = false;
            }).AddCookie("Cookies", option =>
            {
                option.Cookie.Name = AppConfig.CookieName;
                option.Cookie.IsEssential = true;
            }).AddOpenIdConnect(options =>
            {

                options.Authority = Configuracion.Instalador.Contexto.GetSSO() + "/";//AppConfig.UrlSSO;
                options.ClientId = AppConfig.ClientId;
                options.ClientSecret = AppConfig.Secret;
                options.SignedOutRedirectUri = Configuracion.Instalador.Contexto.GetSSO();
                options.SignedOutCallbackPath = "/SSO";

                options.AccessDeniedPath = "/";
                options.ResponseMode = "form_post";
                options.ResponseType = "code id_token";
                options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.SignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.GetClaimsFromUserInfoEndpoint = true;
                options.RequireHttpsMetadata = false;
                options.SaveTokens = true;

                options.Scope.Clear();
                options.Scope.Add("openid");
                options.Scope.Add("profile");
                options.Scope.Add("email");
                options.Scope.Add("offline_access");
                options.Scope.Add("api2.full_access");
                options.Scope.Add("api1");

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = JwtClaimTypes.Name,
                    RoleClaimType = JwtClaimTypes.Role,
                };


                options.Events = new OpenIdConnectEvents
                {
                    OnRemoteFailure = context =>
                    {
                        if (Entorno.Produccion == Configuracion.Instalador.Contexto.QueEjecutar)
                        {
                            context.Response.Redirect($"/rrhh/web/User/SignOut");
                        }
                        else
                        {
                            context.Response.Redirect($"/User/SignOut");
                        }


                        context.HandleResponse();

                        return Task.CompletedTask;
                    },

                    OnTicketReceived = async ctx =>
                    {
                        try
                        {
                            var token = ctx.Properties.GetTokens().FirstOrDefault().Value;
                            var roles = await GetUserClaimsAsync(token);

                            var claims = new List<Claim>();

                            //var element = ctx.Principal.Identity as System.Security.Claims.ClaimsIdentity;


                            foreach (var item in roles)
                            {
                                claims.Add(new Claim(item.ClaimType, item.ClaimValue));
                            }


                            if (roles.Any(c => c.ClaimType == "app_role." + AppConfig.ClientId))
                            {
                                var rol = new Claim(ClaimTypes.Role, roles.FirstOrDefault(c => c.ClaimType == "app_role." + AppConfig.ClientId).ClaimValue);
                                claims.Add(rol);
                            }
                            else
                            {
                                var rol = new Claim(ClaimTypes.Role, "Usuario");
                                claims.Add(rol);
                            }



                            claims.Add(new Claim("access_token", token));
                            var appIdentity = new ClaimsIdentity(claims);

                            ctx.Principal.AddIdentity(appIdentity);

                            await Task.CompletedTask;
                        }
                        catch (Exception ex)
                        {
                            ctx.Response.Redirect($"/rrhh/web?reload");
                            await Task.FromResult(0);
                        }

                    },

                    //OnRedirectToIdentityProviderForSignOut = context =>
                    //{
                    //    //context.Response.Redirect($"https://{SSOConfig.Authority}/logout?client_id={SSOConfig.ClientId}&returnTo={context.Request.Scheme}://{context.Request.Host}/");
                    //    context.HandleResponse();

                    //    return Task.FromResult(0);
                    //}
                };

            });

            //services.AddAuthentication(options =>
            //{

            //    options.DefaultScheme = "Cookies";
            //    options.DefaultChallengeScheme = "oidc";
            //})
            //.AddCookie(options =>
            //{
            //    options.Cookie.Name = "jacquardcrm.cook";
            //})
            //.AddOpenIdConnect("oidc", options =>
            //{
            //    options.Authority = AppConfig.UrlSSO;
            //    //options.RequireHttpsMetadata = false;
            //    options.CallbackPath = new PathString("/signin-oidc"); ;
            //    options.ClientId = AppConfig.ClientId;
            //    options.ClientSecret = "Lmil2JopJBz-GH5tDioogcog";
            //    options.ResponseType = "code id_token";
            //    options.UsePkce = true;

            //    options.Scope.Clear();
            //    options.Scope.Add("openid");
            //    options.Scope.Add("profile");
            //    options.Scope.Add("email");
            //    options.Scope.Add("offline_access");
            //    options.Scope.Add("api2.full_access");
            //    options.Scope.Add("api1");


            //    options.GetClaimsFromUserInfoEndpoint = true;
            //    options.SaveTokens = true;
            //    options.ClaimActions.MapJsonKey("website", "website");

            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        NameClaimType = JwtClaimTypes.Name,
            //        RoleClaimType = JwtClaimTypes.Role,
            //    };

            //    options.Events = new OpenIdConnectEvents
            //    {

            //        OnTicketReceived = async ctx =>
            //        {
            //            var token = ctx.Properties.GetTokens().FirstOrDefault().Value;
            //            var roles = await GetUserRolesAsync(token);

            //            var claims = new List<Claim>();

            //            foreach (var item in roles)
            //            {
            //                claims.Add(new Claim(ClaimTypes.Role, item));
            //            }

            //            var appIdentity = new ClaimsIdentity(claims);

            //            ctx.Principal.AddIdentity(appIdentity);
            //        }
            //    };


            //});




            //services.AddAuthorization(options =>
            //{
            //    var defaultAuthorizationPolicyBuilder = new AuthorizationPolicyBuilder(
            //        CookieAuthenticationDefaults.AuthenticationScheme,
            //        JwtBearerDefaults.AuthenticationScheme);
            //    defaultAuthorizationPolicyBuilder =
            //        defaultAuthorizationPolicyBuilder.RequireAuthenticatedUser();
            //    options.DefaultPolicy = defaultAuthorizationPolicyBuilder.Build();
            //});

            ////services.AddAuthentication("Bearer")
            ////    .AddJwtBearer("Bearer", options =>
            ////    {
            ////        options.Authority = AppConfig.UrlSSO;
            ////        options.Audience = "api1";
            ////        options.RequireHttpsMetadata = AppConfig.RequireHttpsMetadata;
            ////    });

            IntegrateSimpleInjector(services);

            IdentityModelEventSource.ShowPII = true;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Use(async (context, next) =>
            //{
            //    string sHots = context.Request.Host.HasValue == true ? context.Request.Host.Value : "";
            //    sHots = sHots.ToLower();
            //    string sPath = context.Request.Path.HasValue == true ? context.Request.Path.Value : "";
            //    string sQueryString = context.Request.QueryString.HasValue == true ? context.Request.QueryString.Value : "";

            //    if (!context.Request.IsHttps)
            //    {

            //        string new_https_url = "https://" + sHots;
            //        if (sPath != "")
            //        {
            //            new_https_url = new_https_url + sPath;
            //        }
            //        if (sQueryString != "")
            //        {
            //            new_https_url = new_https_url + sQueryString;
            //        }
            //        context.Response.Redirect(new_https_url);
            //        return;
            //    }

            //    await next();
            //});
            //var options = new RewriteOptions()
            //.AddRedirectToHttpsPermanent();

            //app.UseRewriter(options);

            InitializeContainer(app);

            app.UseRequestLocalization();

            //if (env.IsDevelopment())
            //{
            app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //    //app.UseRewriter(new RewriteOptions().AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 443));
            //}



            app.UseHttpsRedirection();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedProto
            });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseCookiePolicy();

            //app.UseMvc();

            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.IsHttps)
            //    {
            //        await next();
            //    }
            //    else
            //    {
            //        var withHttps = Uri.UriSchemeHttps + Uri.SchemeDelimiter + context.Request.QueryString.GetComponents(UriComponents.AbsoluteUri & ~UriComponents.Scheme, UriFormat.SafeUnescaped);
            //        context.Response.Redirect(withHttps);
            //    }
            //});

        }

        private void InitializeContainer(IApplicationBuilder app)
        {


            container.RegisterMvcControllers(app);
            container.RegisterMvcViewComponents(app);
            // Add application presentation components:

            // Add application services. For instance:
            container.Register(typeof(IMediator), typeof(Mediator), Lifestyle.Transient);

            var assemblies = new[] {
                typeof(IST.RRHH.Domain.Startup).Assembly,
            };
            container.Register(typeof(IQueryHandler<,>), assemblies);
            container.Register(typeof(ICommandHandler<>), assemblies);

            container.Register<ICustomUserContext, UserContext>(Lifestyle.Transient);
            //BD
            container.Register<IBDContext>(() => new ContextExtended(AppConfig.ConnectionString), Lifestyle.Scoped);
            //Encolar Email
            container.Register<IEmailJobs, CrearEmailJobs>(Lifestyle.Scoped);

            // Allow Simple Injector to resolve services from ASP.NET Core.
            container.AutoCrossWireAspNetComponents(app);

            container.Register<IServicio, Servicios>(Lifestyle.Transient);
        }

        private void IntegrateSimpleInjector(IServiceCollection services)
        {

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            services.AddHttpContextAccessor();

            services.AddSingleton<IControllerActivator>(
                new SimpleInjectorControllerActivator(container));
            services.AddSingleton<IViewComponentActivator>(
                new SimpleInjectorViewComponentActivator(container));

            services.AddSingleton<Microsoft.AspNetCore.Http.IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();

            services.EnableSimpleInjectorCrossWiring(container);
            services.UseSimpleInjectorAspNetRequestScoping(container);

            //services.AddControllersWithViews();

            //services.AddMvc(d => d.EnableEndpointRouting = false);
        }


        //private async Task<string[]> GetUserRolesAsync(string accessToken)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.SetBearerToken(accessToken);
        //        client.Timeout = TimeSpan.FromMinutes(3);
        //        var response = await client.GetAsync(AppConfig.ManagerApi + "/api/roles");

        //        if (!response.IsSuccessStatusCode)
        //            throw new Exception("No se logró obtener los roles de usuario " + AppConfig.ManagerApi + "api/roles");

        //        var content = await response.Content.ReadAsStringAsync();

        //        return JsonConvert.DeserializeObject<string[]>(content);
        //    }
        //}

        private async Task<List<ClaimsModel>> GetUserClaimsAsync(string accessToken)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.SetBearerToken(accessToken);
                    //client.Timeout = TimeSpan.FromMinutes(3);
                    var response = await client.GetAsync(AppConfig.ManagerApi + "/api/claims");

                    if (!response.IsSuccessStatusCode)
                        throw new Exception("No se logró obtener los roles de usuario " + AppConfig.ManagerApi + "api/claims");

                    var content = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<ClaimsModel>>(content);
                }
            }
            catch (Exception)
            {

                return new List<ClaimsModel>();
            }

        }

    }
    
}
