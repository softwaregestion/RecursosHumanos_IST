using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace IST.RRHH.Web.Controllers
{
    public class CargoController : Controller
    {

        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;

        public CargoController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio)
        {
            this.Mediator = iMediator;
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CargoModel model)
        {
            try
            {
       
                var query = Mediator.Query(new Domain.Query.Cargo.Index.GetAll.Query());

                if (string.IsNullOrEmpty(model.Nombre))
                {
                    TempData["Error"] = "El valor no puede quedar vacío";
                    return View(model);
                }

                if (query.Any(c=>c.Nombre == model.Nombre))
                {
                    TempData["Error"] = "El cargo ya existe";
                    return View(model);
                }
                int folio = query.Max(c => c.CargoId) + 1;
                Mediator.Command(new Domain.Command.Cargo.Create.Command()
                {
                    CargoId = folio,
                    Nombre = model.Nombre
                    
                });
               
                TempData["Success"] = "Registro creado";
            }
            catch (Exception e)
            {
                TempData["Error"] = "En este momento no es posible atenderlo, intente más tarde";
            }
            return RedirectToAction("Cargos", "Aplicaciones");
        }


        public ActionResult Editar(int id)
        {
            var result = Mediator.Query(new Domain.Query.Cargo.Details.GetSingleItem.Query()
            {
                CargoId = id
            });
            CargoModel model = new CargoModel
            {
                CargoId = result.CargoId,
                Nombre = result.Nombre                
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(CargoModel model)
        {
            try
            {
                Mediator.Command(new Domain.Command.Cargo.Edit.Command()
                {
                    CargoId = model.CargoId,
                    Nombre = model.Nombre
                    
                });
                TempData["Success"] = "Editado correctamente";
            }
            catch
            {
                TempData["Error"] = "En este momento no es posible atenderlo, intente más tarde";
            }
            return RedirectToAction("Cargos","Aplicaciones");
        }
 
        public ActionResult Borrar(int id)
        {
            try
            {
                Mediator.Command(new Domain.Command.Cargo.Delete.Command() { CargoId = id });
                TempData["Success"] = "Registro eliminado correctamente";
            }
            catch (Exception e)
            {

                TempData["Error"] = "En este momento no es posible atenderlo, intente más tarde";
            }
            return RedirectToAction("Cargos", "Aplicaciones");
        }

    }
}
