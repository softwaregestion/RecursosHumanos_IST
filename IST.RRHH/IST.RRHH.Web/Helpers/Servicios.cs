using IdentityModel.Client;
using IST.RRHH.Domain.Utilidades;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Configuracion.Instalador.Contexto;

namespace IST.RRHH.Web.Helpers
{
    public class ServiciosSinUsuario : IServicio
    {

        public T CallPostService<T, Y>(Y json, string servicio, bool refreshToken = false)
        {

            using (var client = new HttpClient())
            {
                //client.SetBearerToken(UserLogin.AccessToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var modelx = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");
                var response = client.PostAsync(AppConfig.ManagerApi + "api/" + servicio, modelx).Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    return default(T);
                }
            }

        }


        public T CallGetServiceParameter<T>(object json, string servicio, bool refreshToken = false)
        {

            using (var client = new HttpClient())
            {
                //client.SetBearerToken(UserLogin.AccessToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                var jObj = JObject.FromObject(json);
                var query = String.Join("&",
                            jObj.Children().Cast<JProperty>()
                            .Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));


                var url = AppConfig.ManagerApi + "api/" + servicio + "?" + query;

                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    return default(T);
                }
            }

        }

        public T CallGetService<T>(string servicio, bool refreshToken = false)
        {

            using (var client = new HttpClient())
            {
                //client.SetBearerToken(UserLogin.AccessToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var url = AppConfig.ManagerApi + "api/" + servicio;


                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {

                    return default(T);
                }
            }

        }
    }

    public class Servicios : IServicio
    {
        ICustomUserContext UserLogin;
        IHttpContextAccessor HttpContext;
        public Servicios(ICustomUserContext userLogin, IHttpContextAccessor httpContext)
        {
            UserLogin = userLogin;
            HttpContext = httpContext;
        }

        public T CallPostService<T, Y>(Y json, string servicio, bool refreshToken = false)
        {

            using (var client = new HttpClient())
            {
                client.SetBearerToken(UserLogin.AccessToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var modelx = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");
                var response = client.PostAsync(AppConfig.ManagerApi + "api/" + servicio, modelx).Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        //if (HttpContext.Current != null)
                        //{
                          //  HttpContext.HttpContext.Response.Clear();
//                            HttpContext.HttpContext.Response.Redirect("~/User/SignOut");
                        //}

                        if (Entorno.Produccion == Configuracion.Instalador.Contexto.QueEjecutar)
                        {
                            HttpContext.HttpContext.Response.Redirect($"/rrhh/web/User/SignOut");
                        }
                        else
                        {
                            HttpContext.HttpContext.Response.Redirect($"/User/SignOut");
                        }
                    }

                    //fail token
                    //if(!refreshToken && response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    //{
                    //    GetNewToken();

                    //    return CallPostService<T, Y>(json, servicio, true);
                    //}

                    return default(T);
                }
            }

        }


        public T CallGetServiceParameter<T>(object json, string servicio, bool refreshToken = false)
        {

            using (var client = new HttpClient())
            {
                client.SetBearerToken(UserLogin.AccessToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                var jObj = JObject.FromObject(json);
                var query = String.Join("&",
                            jObj.Children().Cast<JProperty>()
                            .Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));


                var url = AppConfig.ManagerApi + "api/" + servicio + "?" + query;

                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {


                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        if (Entorno.Produccion == Configuracion.Instalador.Contexto.QueEjecutar)
                        {
                            HttpContext.HttpContext.Response.Redirect($"/rrhh/web/User/SignOut");
                        }
                        else
                        {
                            HttpContext.HttpContext.Response.Redirect($"/User/SignOut");
                        }

                        //if (HttpContext.Current != null)
                        //{
                        //    HttpContext.Current.Response.Clear();
                        //    HttpContext.Current.Response.Redirect("~/User/SignOut");
                        //
                        //}
                    }


                    return default(T);
                }
            }

        }

        public T CallGetService<T>(string servicio, bool refreshToken = false)
        {

            using (var client = new HttpClient())
            {
                client.SetBearerToken(UserLogin.AccessToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var url = AppConfig.ManagerApi + "api/" + servicio;

                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {

                        if (Entorno.Produccion == Configuracion.Instalador.Contexto.QueEjecutar)
                        {
                            HttpContext.HttpContext.Response.Redirect($"/rrhh/web/User/SignOut");
                        }
                        else
                        {
                            HttpContext.HttpContext.Response.Redirect($"/User/SignOut");
                        }
                        //throw new Exception("Error token");
                    }

                    //if (!refreshToken && response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    //{
                    //    GetNewToken();

                    //    return CallGetService<T>(servicio, true);
                    //}

                    return default(T);
                }
            }

        }


        private void GetNewToken()
        {
            //try
            //{

            //    var tokenClient = new TokenClient(AppConfig.TokenEndpoint, AppConfig.ClientId, AppConfig.Secret);
            //    var tokenResponse = tokenClient.RequestRefreshTokenAsync(UserLogin.AccessToken).Result;
            //    if (!tokenResponse.IsError)
            //    {
            //        UserLogin.AccessToken = tokenResponse.AccessToken;
            //    }

            //}
            //catch
            //{


            //}

        }



    }
}
