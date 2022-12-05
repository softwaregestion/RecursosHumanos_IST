
using IST.RRHH.Web.Helpers;
using IST.SSO.Api.Data;
using Jacquard.SSO.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc; 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Controllers
{
    public class RecoveryController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public RecoveryController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Recovery([FromQuery] string mobile)
        {
            var model = new ModelUsers();
            if (!string.IsNullOrEmpty(mobile))
            {
                model.IsMobile = true;
            }
            else
            {
                model.IsMobile = false;
            }

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Recovery(ModelUsers model)
        {
            var context = new Contexto();

            if (string.IsNullOrEmpty(model.Email))
            {
                TempData["Error"] = "Usuario no puede quedar en blanco";

                return View(model);
            }

            if (model.Email is null) model.Email = "";

            if (!string.IsNullOrEmpty(model.Email) && !ValidarEmail(model.Email))
            {
                TempData["Error"] = "Formato de E-mail no es válido";

                return View(model);
            }





            var data = await context.AspNetUsers.FirstOrDefaultAsync(c => c.Email == model.Email.ToLower());
            if (data == null)
            {
                TempData["Error"] = "Usuario no existente";

                return View(model);
            }

            var recoveryId = Guid.NewGuid();

            var recovery = await context.AspNetUserClaims.FirstOrDefaultAsync(c => c.UserId == data.Id && c.ClaimType == "_recovery");
            if (recovery != null)
            {
                recovery.ClaimValue = recoveryId.ToString();
            }
            else
            {
                context.AspNetUserClaims.AddAsync(new AspNetUserClaims { UserId = data.Id, ClaimValue = recoveryId.ToString(), ClaimType = "_recovery" });
            }

            await context.SaveChangesAsync();


            TempData["Success"] = "Dentro de los próximos minutos se enviará un correo electrónico con un código para restablecer su contraseña";

            //
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var obj = new { Email = $"{data.Email}", Id = data.Id, recoveryId = recoveryId };

                //var modelx = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                //var response = client.PostAsync(AppConfig.ApiHost + "/api/enviarmailrecovery", modelx).Result;

              
                var mensaje = string.Format(@"Sr/a, {0}
                                                                            <br/><br/> 
                                                                            Se ha solicitado la recuperación de su contraseña,  para continuar haga click en el siguiente <a href='" + AppConfig.UrlWeb + @"/recovery/recoverynewpassword/{2}?recoveryid={1}'>enlace</a>  <br/><br/> 
                                                                            El código de validación es: <strong> {3} </strong>                                                                            
                                                                            <br/><br/> 
                                                                            <strong>No responder mail generado automaticamente.</strong>  

                ",          
                
                data.Email, recoveryId, data.Id, recoveryId.ToString().Substring(0, 4).ToLower());
                
                var util = new Helpers.Email();
                util.smtp = AppConfig.Smtp;
                util.emailOrigen = AppConfig.EmailOrigen;
                util.passwordOrigen = AppConfig.PasswordOrigen; 
                util.port = AppConfig.Port; 
                util.enableSsl = AppConfig.SSL;
                     

                var x = util.EnviarEmail(data.Email, "Solicitado de restablecer contraseña", mensaje.ToString());

                if (!x)
                {
                    TempData["Error"] = "No se logró enviar el email";
                    //throw new Exception("No se logró enviar el email");
                }



            }



            //if (model.IsMobile)
            //{
                return RedirectToAction("Recovery", "Recovery", new { mobile = model.IsMobile });
            //}
           // else
            //{
              //  return RedirectToAction("login", "account");
            //}

            //return RedirectToAction("login", "account");
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> RecoveryNewPassword(string id)
        {
            var context = new Contexto();
            var model = new ModelUsers();
            model.Id = id;

            var recoveryd = await context.AspNetUserClaims.FirstOrDefaultAsync(c => c.UserId == id && c.ClaimType == "_recovery");
            if (recoveryd != null)
            {
                if (recoveryd.ClaimValue == Request.Query["recoveryId"].ToString())
                {
                    model.recoveryId = Request.Query["recoveryId"].ToString().Substring(0, 4);
                    return View(model);
                }
                else
                {
                    TempData["Error"] = "Id de recovery incorrecto";
                    return RedirectToAction("login", "account");
                }
            }
            else
            {

                TempData["Error"] = "Id de recovery incorrecto";
                return RedirectToAction("login", "account");
            }
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RecoveryNewPassword(ModelUsers model)
        {
            var context = new Contexto();

            if (model.Codigo != model.recoveryId)
            {
                TempData["Error"] = "Código no válido, favor ingresar un código válido";

                return View(model);
            }

            if (model.Contrasena != model.ContrasenaConfirmacion)
            {
                TempData["Error"] = "las contraseñas no coinciden";

                return View(model);
            }

            var expresion = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*.-_?&])([A-Za-z\d$@$!%*.-_?&]|[^ ]){8,16}$";
            if (!Regex.IsMatch(model.Contrasena, expresion))
            {
                TempData["Error"] = "La contraseña debe tener al entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula, al menos una mayúscula, y almenos 1 de estos simbolos (@,!,%,*,.,-,_,?,&).";

                return View(model);
            }

            var data = await context.AspNetUsers.SingleOrDefaultAsync(c => c.Id == model.Id);
            data.PasswordHash = "AQAAAAEAACcQAAAAEMn0BrOBD7QCedcAJp3SYwDga0Yq46sb1joqlV+xU6fG3mon4O9pYyGubc5xC6dCpg==";
            data.SecurityStamp = "G7LMJWIIHMSYLKNLZPQ7C4WIQ47QYY3H";
            data.ConcurrencyStamp = DateTime.Now.ToString();
            data.LockoutEnabled = true;

            await context.SaveChangesAsync();

            ApplicationUser userAsync = await this._userManager.FindByIdAsync(model.Id.ToString());
            if (userAsync != null)
            {
                var result = await this._userManager.ChangePasswordAsync(userAsync, "1234", model.Contrasena);
                if (result.Errors.Count() > 0)
                {
                    TempData["Error"] = string.Join("; ", result.Errors);
                }
            }


            TempData["Success"] = "Se ha actualizado la contraseña correctamente.";


            return RedirectToAction("login", "account");
        }


        private bool ValidarEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
