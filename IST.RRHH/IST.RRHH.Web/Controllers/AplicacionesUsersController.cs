using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace IST.RRHH.Web.Controllers
{
    [AllowAnonymous]
    //[Authorize]
    public class AplicacionesUsersController : Controller
    {
        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;

        public AplicacionesUsersController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio)
        {
            this.Mediator = iMediator;
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
        }


        [HttpGet]
        public IActionResult Index(int? id, string rol, string UserId) 
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });

           


            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }
                        
                        select new AplicacionesModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).ToList();

            if (data.Count > 0)
            {
                model.Usuarios = data;
            }

            model.UserApp = context.AspNetUserClaims.Where(c => c.ClaimType == "application").ToList();

            if (UserId != null)
            {
                model.UserId = UserId;
            }
            if (id != null)
            {
                
                if (model.Aplicaciones.Any(c => c.Id == id.Value))
                {
                    var clientid = model.Aplicaciones.SingleOrDefault(c => c.Id == id.Value);
                    if (clientid != null)
                    {
                        var x = context.AspNetUserClaims.Where(c => c.ClaimType == "application" && c.ClaimValue == clientid.ClientName).ToList();
                        if (x.Count > 0)
                        {
                            var usersid = x.Select(c => c.UserId).Distinct().ToList();
                            model.Usuarios.RemoveAll(c => !usersid.Contains(c.Id));

                            if (rol != null) //rol
                            {
                                var xx = context.AspNetUserClaims.Where(c => c.ClaimType == "app_role." + clientid.ClientName).ToList();
                                if (xx.Count > 0)
                                {
                                    var usersidrol = xx.Where(c=>c.ClaimValue == rol).Select(c => c.UserId).Distinct().ToList();

                                    model.Usuarios.RemoveAll(c => !usersidrol.Contains(c.Id));

                                }
                            }
                        }
                        else
                        {
                            model.Usuarios = new List<AplicacionesModelUsers>();
                        }
                    }
                    else
                    {
                        model.Usuarios = new List<AplicacionesModelUsers>();
                    }
                }
            }


            if (UserId != null)
            {
                model.Usuarios.RemoveAll(c => c.Id != UserId);
            }
            //else
            //{
            //    model.Usuarios = new List<AplicacionesModelUsers>();
            //}            

            return View(model);
        }

        [HttpGet]
        public IActionResult IndexRecovery(int? id)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });




            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }

                        select new AplicacionesModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).ToList();

            if (data.Count > 0)
            {
                model.Usuarios = data;
            }

            model.UserApp = context.AspNetUserClaims.Where(c => c.ClaimType == "application").ToList();

            if (id != null)
            {
                if (model.Aplicaciones.Any(c => c.Id == id.Value))
                {
                    var clientid = model.Aplicaciones.SingleOrDefault(c => c.Id == id.Value);
                    if (clientid != null)
                    {
                        var x = context.AspNetUserClaims.Where(c => c.ClaimType == "application" && c.ClaimValue == clientid.ClientName).ToList();
                        if (x.Count > 0)
                        {
                            var usersid = x.Select(c => c.UserId).Distinct().ToList();
                            model.Usuarios.RemoveAll(c => !usersid.Contains(c.Id));
                        }
                        else
                        {
                            model.Usuarios = new List<AplicacionesModelUsers>();
                        }
                    }
                    else
                    {
                        model.Usuarios = new List<AplicacionesModelUsers>();
                    }
                }
            }
            //else
            //{
            //    model.Usuarios = new List<AplicacionesModelUsers>();
            //}            

            return View(model);
        }

        [HttpGet]
        public IActionResult IndexMensaje(int? id)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });




            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }

                        select new AplicacionesModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).ToList();

            if (data.Count > 0)
            {
                model.Usuarios = data;
            }

            model.UserApp = context.AspNetUserClaims.Where(c => c.ClaimType == "application").ToList();

            if (id != null)
            {
                if (model.Aplicaciones.Any(c => c.Id == id.Value))
                {
                    var clientid = model.Aplicaciones.SingleOrDefault(c => c.Id == id.Value);
                    if (clientid != null)
                    {
                        var x = context.AspNetUserClaims.Where(c => c.ClaimType == "application" && c.ClaimValue == clientid.ClientName).ToList();
                        if (x.Count > 0)
                        {
                            var usersid = x.Select(c => c.UserId).Distinct().ToList();
                            model.Usuarios.RemoveAll(c => !usersid.Contains(c.Id));
                        }
                        else
                        {
                            model.Usuarios = new List<AplicacionesModelUsers>();
                        }
                    }
                    else
                    {
                        model.Usuarios = new List<AplicacionesModelUsers>();
                    }
                }
            }
            //else
            //{
            //    model.Usuarios = new List<AplicacionesModelUsers>();
            //}            

            return View(model);
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult Up(string msj)
        {
            
            return View(new { msj = msj });
        }


        /**********************************************/

        public IActionResult Clients(string id)
        {

            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);


            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }
                        where user.Id == id
                        select new ModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).FirstOrDefault();




            var client = context.Clients.Where(c => c.Id > 10).Select(c => c.ClientName).ToList();

            //client.RemoveAll(c => c == "externo2");

            data.AppSystem = client;
            data.Clients = context.AspNetUserClaims.Where(c => c.ClaimType == "application" && c.UserId == id).Select(c => new Helpers.ModelClients { Nombre = c.ClaimValue, Id = c.Id }).ToList();
            data.ClientsAdminUser = context.AspNetUserClaims.Where(c => c.ClaimType == "AdministradorApp" && c.UserId == id).Select(c => new Helpers.ModelClients { Nombre = c.ClaimValue, Id = c.Id }).ToList();




            return View(data);
        }

        public IActionResult DeleteApplication(string id, string item)
        {

            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var element = context.AspNetUserClaims.SingleOrDefault(c => c.ClaimType == "application" && c.UserId == id && c.ClaimValue == item);
            if (element != null)
            {
                context.AspNetUserClaims.Remove(element);


                var idx = $"app_role.{item}";

                var rol = context.AspNetUserClaims.Where(c => c.ClaimType == idx && c.UserId == id).ToList();
                context.AspNetUserClaims.RemoveRange(rol);

                context.SaveChanges();
            }



            return RedirectToAction("Clients", new { id });
        }

        public IActionResult DeleteApplicationAdminUser(string id, string item)
        {

            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var element = context.AspNetUserClaims.SingleOrDefault(c => c.ClaimType == "AdministradorApp" && c.UserId == id && c.ClaimValue == item);
            if (element != null)
            {
                context.AspNetUserClaims.Remove(element);

                context.SaveChanges();
            }



            return RedirectToAction("Clients", new { id });
        }

        public IActionResult AddApplication(string id, string item)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            context.AspNetUserClaims.Add(new Model.AspNetUserClaims { ClaimType = "application", ClaimValue = item, UserId = id.ToString() });
             

            context.SaveChanges();

            return RedirectToAction("Clients", new { id });
        }
        public IActionResult AddApplicationAdminUser(string id, string item)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            context.AspNetUserClaims.Add(new  Model.AspNetUserClaims { ClaimType = "AdministradorApp", ClaimValue = item, UserId = id.ToString() });

            context.SaveChanges();

            return RedirectToAction("Clients", new { id });
        }

        //************************




        public IActionResult Roles(string id)
        {



            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);


            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }
                        where user.Id == id
                        select new ModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).FirstOrDefault();


            //data.AppSystem = context.AspNetUserClaims.Where(c => c.ClaimType == "application" && c.UserId == id).ToList().Select(c => c.ClaimValue).Distinct().ToList();

            var client = context.Clients.Where(c => c.Id > 10).ToList();

            var app = client.Select(c => c.ClientName).ToList();

            //app.RemoveAll(c => c == "externo2");

            data.App = client;

            var roles = context.ClientClaims.Where(c => c.Type == "Rol").ToList();

            data.Roles = roles;

            data.AppSystem = context.AspNetUserClaims.Where(c => c.ClaimType == "application" && c.UserId == id).ToList().Select(c => c.ClaimValue).Distinct().ToList();

            data.Rols = new List<Helpers.ModelRol>();
            foreach (var application in data.AppSystem)
            {
                var ClaimType = $"app_role.{application}";

                var rol = context.AspNetUserClaims.Where(c => c.ClaimType == ClaimType && c.UserId == id).ToList();
                if (rol.Count > 0)
                {
                    data.Rols.AddRange(rol.Select(c => new Helpers.ModelRol { Nombre = c.ClaimValue, Clients = c.ClaimType.Replace("app_role.", "") }));
                }
            }

            return View(data);
        }

        public IActionResult DeleteRoles(string id, string application, string rol)
        {

            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var ClaimType = $"app_role.{application}";

            var element = context.AspNetUserClaims.FirstOrDefault(c => c.ClaimType == ClaimType && c.UserId == id && c.ClaimValue == rol);
            if (element != null)
            {
                context.AspNetUserClaims.Remove(element);
                context.SaveChanges();
            }

            ViewBag.Success = "Rol Eliminado correctamente";

            return RedirectToAction("Roles", new { id });
        }

        public IActionResult AddRoles(string id, string application, string rol)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            if (!string.IsNullOrEmpty(rol))
            {
                var ClaimType = $"app_role.{application}";

                if (!context.AspNetUserClaims.Any(c => c.ClaimType == ClaimType && c.ClaimValue == rol && c.UserId == id.ToString()))
                {

                    var ttx = $"app_role.{application}";

                    context.AspNetUserClaims.Add(new  Model.AspNetUserClaims { ClaimType = ttx, ClaimValue = rol, UserId = id.ToString() });

                    context.SaveChanges();

                    ViewBag.Success = "Rol creado correctamente";
                }
                else
                {
                    ViewBag.Error = "Rol ya existe en el sistema";
                }
            }
            else
            {
                ViewBag.Error = "Rol en blanco";
            }

            return RedirectToAction("Roles", new { id });
        }


        public IActionResult Borrar(string id)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);



            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }
                        where user.Id == id
                        select new ModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).FirstOrDefault();


            return View(data);
        }

        [HttpPost]
        public IActionResult Borrar(ModelUsers model)
        {

            if (!string.IsNullOrEmpty(model.Email) && !ValidarEmail(model.Email))
            {
                ViewBag.Error = "Formato de Email no es valido";

                return View(model);
            }

            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var userClaims = context.AspNetUserClaims.Where(c => c.UserId == model.Id).ToList();
            if (userClaims.Count() > 0)
            {
                context.AspNetUserClaims.RemoveRange(userClaims);
            }

            var user = context.AspNetUsers.SingleOrDefault(c => c.Id == model.Id);
            if (user != null)
            {
                context.AspNetUsers.Remove(user);
            }

            context.SaveChanges();

            ViewBag.Success = "Usuario Borrado Correctamente";

            return RedirectToAction("Index", "AplicacionesUsers");
        }

        private static bool ValidaRut(string rut)
        {
            if (rut == null)
            {
                rut = string.Empty;
            }

            if (rut == "1-9")
            {
                return true;
            }


            if (rut.IndexOf("-") < 0)
            {
                return false;
            }

            if (rut.IndexOf(".") < 0)
            {
                return false;
            }



            rut = rut.Replace(".", "").ToUpper();

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
                validacion = false;
            }

            return validacion;


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
