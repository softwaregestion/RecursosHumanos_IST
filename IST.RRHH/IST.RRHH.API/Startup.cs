using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SimpleInjector;
using SimpleInjector.Lifestyles;
using IST.RRHH.API.Helpers.App;
using IST.RRHH.API.Helpers;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SimpleInjector.Integration.AspNetCore.Mvc;
using System.Globalization;
using IST.RRHH.Model;
using IST.RRHH.Domain.Jobs;

namespace IST.RRHH.API
{
    public class Startup
    {
        private Container container = new Container();
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            // ASP.NET default stuff here
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddXmlFile("app.config")
               .AddEnvironmentVariables();
            Configuration = builder.Build();

            IST.RRHH.Domain.Startup.Path = env.ContentRootPath + "\\";
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();


            var cultureInfo = new CultureInfo("es-CL");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


            services.AddControllers().AddNewtonsoftJson();




            IST.RRHH.Domain.Startup.ConnectionString = AppConfig.CustomEntityUrl;

            services.AddScoped<IBDContext>(_ => new ContextExtended(AppConfig.CustomEntityUrl));

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = AppConfig.UrlSSO;
                    options.Audience = "api1";
                    options.RequireHttpsMetadata = AppConfig.RequireHttpsMetadata;
                });

            IntegrateSimpleInjector(services);

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
        }

        public void Configure(IApplicationBuilder app)
        {

            InitializeContainer(app);

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=test}/{action=get}/{id?}");
            });
        }

        private void InitializeContainer(IApplicationBuilder app)
        {



            // Add application presentation components:
            container.RegisterMvcControllers(app);
            container.RegisterMvcViewComponents(app);

            // Add application services. For instance:
            container.Register(typeof(IMediator), typeof(Mediator), Lifestyle.Scoped);

            var assemblies = new[] {
                    typeof(IST.RRHH.Domain.Startup).Assembly,
                };
            container.Register(typeof(IQueryHandler<,>), assemblies);
            container.Register(typeof(ICommandHandler<>), assemblies);

            container.RegisterConditional(typeof(ILoggerx),
                  context => typeof(NLogApp<>).MakeGenericType(context.Consumer == null ? typeof(Object) : context.Consumer.ImplementationType),
                  Lifestyle.Singleton, context => true);

            container.Register<ICustomUserContext, UserContext>(Lifestyle.Scoped);


            //Encolar Email
            container.Register<IEmailJobs, CrearEmailJobs>(Lifestyle.Scoped);


            // Allow Simple Injector to resolve services from ASP.NET Core.
            container.AutoCrossWireAspNetComponents(app);
        }
    }
}
