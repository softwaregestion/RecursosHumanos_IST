using IdentityServer4;
using IST.RRHH;
using IST.RRHH.Domain.Jobs;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Model; 
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Controllers
{
    [Authorize()]
    public class UserController : Controller
    {
        private readonly IMediator Mediator;
        private readonly ICustomUserContext UserLogin;
        private readonly IBDContext Context;
        private readonly IServicio Servicio;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IEmailJobs Email;

        public UserController(IMediator iMediator, ICustomUserContext iCustomUserContext, IBDContext iBDContext, IServicio servicio, IHostingEnvironment hostingEnvironment, IEmailJobs email)
        {
            this.Mediator = iMediator;
            
            this.UserLogin = iCustomUserContext;
            this.Context = iBDContext;
            this.Servicio = servicio;
            this.Email = email; 
            _hostingEnvironment = hostingEnvironment;
        }

        public ActionResult Create()
        {
            UserIndexModel model = new UserIndexModel();
            
            try
            {
                
                CargarVariablesParametricas(model);
                model.Activo = true;
                //model.ddlRoles.RemoveAll(c => c.Text != "Administrador");

            }
            catch (Exception ex)
            {

                throw;
            }
            
            return View(model);
        }

        public ActionResult Adjuntar(string userId)
        {
            UserIndexModel model = new UserIndexModel();

            try
            {

                model.UserId = userId;

                var obj = new { id = model.UserId };
                var data = this.Servicio.CallGetServiceParameter<UserIndexDetailsModel>(obj, "User");
                model.Contrato = data.Contrato;
                model.Firma = data.Firma;
                model.Foto = data.Foto;
                 

            }
            catch (Exception ex)
            {

                throw;
            }

            return View(model);
        }




        [HttpPost]
        public ActionResult Adjuntar(UserIndexModel model, List<IFormFile> filescontratos, List<IFormFile> filesfirmas, List<IFormFile> filesfoto)
        {
        
           
            try
            {
                //create user
                var Foto = CargarAdjunto(model, filesfoto);
                var Contrato = CargarAdjunto(model, filescontratos);
                var Firma = CargarAdjunto(model, filesfirmas);

                if (!string.IsNullOrEmpty(Firma))
                {
                    this.Mediator.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "firma", ClaimValue = Firma });
                }

                if (!string.IsNullOrEmpty(Contrato))
                {
                    this.Mediator.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "contrato", ClaimValue = Contrato });
                }
                if (!string.IsNullOrEmpty(Foto))
                {
                    this.Mediator.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "foto", ClaimValue = Foto });
                }

                TempData["Success"] = "cargado correctamente.";


                return RedirectToAction("admin", "User", new { UserId = model.UserId });
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;

                return RedirectToAction("Create", "User");
            }

        }




        [HttpPost]
        public ActionResult Create(UserIndexModel model, List<IFormFile> filescontratos, List<IFormFile> filesfirmas, List<IFormFile> filesfoto)
        {
            CargarVariablesParametricas(model);
            model.Activo = true;
            var id = Guid.NewGuid();
            
            var Foto = "";
            var Contrato = "";
            var Firma = "";


            model.UserId = id.ToString();
            try
            {
                //create user
                Foto = CargarAdjunto(model, filesfoto);
                Contrato = CargarAdjunto(model, filescontratos);
                Firma = CargarAdjunto(model, filesfirmas);

                if (string.IsNullOrEmpty(model.Email))
                {
                    TempData["Error"] = "Usuario no puede quedar en blanco";

                    return View(model);
                }

                if (string.IsNullOrEmpty(model.Fecha))
                {
                    TempData["Error"] = "Usuario no puede quedar sin fecha de cumpleaños";

                    return View(model);
                }

                if (Context.AspNetUsers.Any(c => c.UserName == model.Email.ToLower()))
                {
                    TempData["Error"] = "Usuario ya existente";

                    return View(model);
                }

                if (model.Email is null) model.Email = "";

                if (!string.IsNullOrEmpty(model.Email) && !ValidarEmail(model.Email))
                {
                    TempData["Error"] = "Formato de Email no es valido";

                    return View(model);
                }

                string emailMin = model.Email.ToLower();
                if (Context.AspNetUsers.Any(c => c.Email == emailMin))
                {
                    TempData["Error"] = "Email ingresado ya existe en el sistema";

                    return View(model);
                }

                Context.AspNetUsers.Add(new AspNetUsers
                {
                    Id = id.ToString(),
                    AccessFailedCount = 0,
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    Email = model.Email.ToLower(),
                    EmailConfirmed = false,
                    LockoutEnabled = false,
                    LockoutEnd = null,
                    NormalizedEmail = model.Email.ToUpper(),
                    NormalizedUserName = model.Email.ToUpper(),
                    PasswordHash = "AQAAAAEAACcQAAAAEMn0BrOBD7QCedcAJp3SYwDga0Yq46sb1joqlV+xU6fG3mon4O9pYyGubc5xC6dCpg==",
                    PhoneNumber = "",
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "G7LMJWIIHMSYLKNLZPQ7C4WIQ47QYY3H",
                    TwoFactorEnabled = false,
                    UserName = model.Email.ToLower()
                });

                Context.SaveChanges();

                if (string.IsNullOrEmpty(model.Nombres))
                {
                    model.Nombres = string.Empty;
                }

                if (string.IsNullOrEmpty(model.Rut))
                {
                    model.Rut = string.Empty;
                }

                if (string.IsNullOrEmpty(model.ApellidoPaterno))
                {
                    model.ApellidoPaterno = string.Empty;
                }

                if (string.IsNullOrEmpty(model.Rut))
                {
                    model.Rut = string.Empty;
                }

                if (string.IsNullOrEmpty(model.ApellidoMaterno))
                {
                    model.ApellidoMaterno = string.Empty;
                }

                if (string.IsNullOrEmpty(model.Direccion))
                {
                    model.Direccion = string.Empty;
                }

                if (string.IsNullOrEmpty(model.Edad))
                {
                    model.Edad = string.Empty;
                }

                if (string.IsNullOrEmpty(model.Telefono))
                {
                    model.Telefono = string.Empty;
                }

                if (string.IsNullOrEmpty(model.Cargo))
                {
                    model.Cargo = "0";
                }




                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "email_ref", ClaimValue = model.Email, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "nombres", ClaimValue = model.Nombres, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "rut", ClaimValue = model.Rut, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "apellido_paterno", ClaimValue = model.ApellidoPaterno, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "apellido_materno", ClaimValue = model.ApellidoMaterno, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "direccion", ClaimValue = model.Direccion, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "telefono", ClaimValue = model.Telefono, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "celular", ClaimValue = model.Celular, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "estado", ClaimValue = "Autorizado", UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "cargo", ClaimValue = model.Cargo, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "fecha_Cumpleanos", ClaimValue = model.Fecha, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "dia_cumpleanos", ClaimValue = model.Fecha.Substring(0,5), UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "fecha_Creacion", ClaimValue = DateTime.Now.ToString(), UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "ProximaRenovacionPassword", ClaimValue = DateTime.Now.AddYears(1).ToString(), UserId = id.ToString() });

                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "Foto", ClaimValue = Foto, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "Firma", ClaimValue = Firma, UserId = id.ToString() });
                Context.AspNetUserClaims.Add(new AspNetUserClaims { ClaimType = "Contrato", ClaimValue = Contrato, UserId = id.ToString() });



                Context.SaveChanges();

                TempData["Success"] = "Usuario creado correctamente.";

                var obj = new { id = id };
                var dato = this.Servicio.CallGetServiceParameter<object>(obj, "usercreatedefaultpassword");

                //this.Email.SendMail(model.Email, "Confirmación de creación de usuario", string.Format(@"Estimado/a, {0}
                //<br/><br/> 
                //Se ha ingresado su usuario con exito. No olvide que su contraseña por defecto es 1234. 
                //<br/><br/> 
                //<strong>No responder mail generado automaticamente.</strong>                                                                            
                //", model.Email));

                return RedirectToAction("index", "aplicacionesusers", new { UserId = id });
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;

                return RedirectToAction("Create", "User");
            }
             
        }

        private string CargarAdjunto(UserIndexModel model, List<IFormFile> files)
        {
            if (files != null && files.Count > 0)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    var originalFileName = Path.GetFileName(files[i].FileName);
                    var pathExtension = Path.GetExtension(files[i].FileName); 
                    var pathx = "/Content/Usuarios/" + model.UserId + "/" + Guid.NewGuid() + "";
                    var directorio = _hostingEnvironment.WebRootPath + pathx;
                    if (!Directory.Exists(directorio))
                        Directory.CreateDirectory(directorio);

                    var path = Path.Combine(directorio, files[i].FileName);
                    var pathserver = Path.Combine(pathx, files[i].FileName);                  

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        files[0].CopyTo(stream);
                    }

                    return pathserver;

                }
            }


            return "";
        }

        public void LogoCliente(string idEjecutivo)
        {
            var claims = Mediator.Query(new IST.RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = UserLogin.UserId });
            
            var claimLogo = claims.SingleOrDefault(d => d.ClaimType == "logo").ClaimValue;

            Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = idEjecutivo, ClaimType = "logo", ClaimValue = claimLogo });
        }
         
        public ActionResult Account()
        {
            return View();
        }

        public ActionResult Admin()
        {
            var model = new UserIndexModel();

            if (Request.Query["UserId"].ToString() != null) //usuario grabado
            {
                model.UserId = Request.Query["UserId"].ToString();


                var obj = new { id = model.UserId };

                //SERVICIO CALL GET SERVICE PARAMETER NO ESTAN TRAYENDO DATOS
                var data = this.Servicio.CallGetServiceParameter<UserIndexDetailsModel>(obj, "User");
                model.Contrato = data.Contrato;
                model.Firma = data.Firma;
                model.Foto = data.Foto;

            }

            CargarVariablesParametricas(model);

            if (Request.Query["UserId"].ToString() != null) //usuario grabado
            {
                model.Items = this.Servicio.CallGetService<List<UserIndexDataModel>>("UserAdmin" + "?id=" + model.UserId);
            }
            else

            {
                model.Items = this.Servicio.CallGetService<List<UserIndexDataModel>>("UserAdmin");
            }
            

            return View(model);
        }

       

        [HttpPost]
        public ActionResult Admin(UserIndexModel model)
        {
            
            var boton = Request.Query["btnPost"];
            switch (boton)
            {
                case "Rechazo":
                    model.Estado = "Rechazado";
                    model.Activo = false;
                    break;
                case "Autorizo":
                    model.Estado = "Autorizado";
                    model.Activo = true;
                    break;
            }

            this.Servicio.CallPostService<UserIndexModel, UserIndexModel>(model, "User");

            //model.Items = this.Servicio.CallGetService<List<UserIndexDataModel>>("UserAdmin");
            CargarVariablesParametricas(model);

            TempData["Success"] = "Se ha grabado correctamente.";

            return RedirectToAction("Admin", new { UserId = model.UserId });
        }

        public ActionResult AdminClientesChange(UserIndexModel model)
        {
            return RedirectToAction("Admin");
        }
         

        // GET: User
        public ActionResult Authorize()
        {
            var model = new UserIndexModel();
            model.Items = this.Servicio.CallGetService<List<UserIndexDataModel>>("UserSolicitante");
            CargarVariablesParametricas(model);

            if (Request.Form["UserId"].ToString() != null) //usuario grabado
            {
                model.UserId = Request.Form["UserId"].ToString();
            }

            return View(model);
        }
         

        [HttpPost]
        public ActionResult Authorize(UserIndexModel model)
        {

            var boton = Request.Form["btnPost"].ToString();
            switch (boton)
            {
                case "Rechazo":
                    model.Estado = "Rechazado";
                    model.Activo = false;
                    break;
                case "Autorizo":
                    model.Estado = "Autorizado";
                    model.Activo = false;
                    break;

            }

            var servicio = this.Servicio.CallPostService<UserIndexModel, UserIndexModel>(model, "User");
            model.Items = this.Servicio.CallGetService<List<UserIndexDataModel>>("UserSolicitante");
            CargarVariablesParametricas(model);

            try
            {


                if (boton == "Grabar")
                {
                    return RedirectToAction("Authorize", new { UserId = model.UserId });
                }
                else if (boton == "Rechazo")
                {
                    TempData["Success"] = $"Los usuarios fueron rechazados correctamente.";
                    return RedirectToAction("Authorize");
                }
                else if (boton == "Autorizo")
                {
                    return RedirectToAction("Admin", new { UserId = model.UserId });
                }
            }
            catch (Exception)
            {
                TempData["Error"] = $"Se ha  generado un error, intente más tarde";
                return RedirectToAction("Authorize");
            }

            return RedirectToAction("Authorize");


        }

        [HttpPost]
        public ActionResult AuthorizeList(UserIndexModel model)
        {
            if (!string.IsNullOrEmpty(model.jsonListadoAutorizacion))
            {
                model.ListadoAutorizacion = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(model.jsonListadoAutorizacion);
            }


            var boton = Request.Form["btnPost"].ToString();
            switch (boton)
            {
                case "Rechazo":
                    model.Estado = "Rechazado";
                    model.Activo = false;

                    break;
                case "Autorizo":
                    model.Estado = "Autorizado";
                    model.Activo = true;

                    break;

            }

            model.UserId = this.UserLogin.UserId;
            var servicio = this.Servicio.CallPostService<UserIndexModel, UserIndexModel>(model, "UserAutorizacion");

            return RedirectToAction("Authorize");
        }

        private void CargarVariablesParametricas(UserIndexModel model)
        {
            model.ddlCargo = this.Servicio.CallGetService<List<ParametricaData>>("ParametricaCargo");
        }

        [AllowAnonymous]
        public ActionResult RecoveryPassword(string id)
        {
            var obj = new { id = id };
            var dato = this.Servicio.CallGetServiceParameter<object>(obj, "UserResetPassword");


            return View();
        }


        [AllowAnonymous]
        public ActionResult BorrarAdjunto(string id)
        {
            

            return View();
        }


        [AllowAnonymous]
        public async Task<ActionResult> SignOutAsync()
        {
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("OpenIdConnect");

            
            return new SignOutResult(new[] { "Cookies", "OpenIdConnect" });
        }

        public ActionResult VerAdjunto(string UserId, string Tipo )
        {

            var obj = new { id = UserId };
            var data = this.Servicio.CallGetServiceParameter<UserIndexDetailsModel>(obj, "User");

            string path = "";
            switch (Tipo)
            {
                case "Contrato":
                    path = data.Contrato;
                    break;
                case "Firma":
                    path = data.Firma;
                    break;
                case "Foto":
                    path = data.Foto;
                    break;
            }


            
            byte[] fileBytes = System.IO.File.ReadAllBytes(_hostingEnvironment.WebRootPath + path);
            string fileName = Path.GetFileName(path);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            
           
        }

        //web api 
        [HttpPost]
        public ActionResult userdata(UserIndexDetailsModel model)
        {
            var obj = new { id = model.UserId };
            var data = this.Servicio.CallGetServiceParameter<UserIndexDetailsModel>(obj, "User");
            return Json(data);
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
