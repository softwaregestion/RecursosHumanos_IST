using IdentityServer4;
using IST.RRHH;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Model; 
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Controllers
{
    [Authorize()]
    public class ClientController : Controller
    {
        IMediator Mediator;        
        ICustomUserContext UserLogin;
        IBDContext Context;
        IServicio Servicio;

        public ClientController(IMediator iMediator, ICustomUserContext iCustomUserContext, IBDContext iBDContext, IServicio servicio)
        {
            this.Mediator = iMediator;
            
            this.UserLogin = iCustomUserContext;
            this.Context = iBDContext;
            this.Servicio = servicio;
        }
 

   
        public ActionResult Admin()
        {
            var model = new ClientIndexModel();

            if (Request.Query["ClientId"].ToString() != null) //usuario grabado
            {
                model.ClientId = Request.Query["ClientId"].ToString();
            }
             

            if (Request.Query["ClientId"].ToString() != null) //usuario grabado
            {
                var items = this.Servicio.CallGetService<List<ClientIndexDataModel>>("clientadmin" + "?id=" + model.ClientId); 
                model.Items = items   ;
            }
            
            

            return View(model);
        }

       

        [HttpPost]
        public ActionResult Admin(ClientIndexModel model)
        {
            
            var boton = Request.Query["btnPost"];
            switch (boton)
            {
                case "Rechazo":
                   
                    break;
                case "Autorizo":
                  
                    break;
            }

            this.Servicio.CallPostService<ClientIndexModel, ClientIndexModel>(model, "Client");
 
             

            TempData["Success"] = "Se ha grabado correctamente.";

            return RedirectToAction("Admin", new { ClientId = model.ClientId });
        }


        [HttpPost]
        public ActionResult clientdata(ClientIndexModel model)
        {
            var obj = new { id = model.ClientId };
            var data = this.Servicio.CallGetServiceParameter<ClientIndexModel>(obj, "Client");
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
