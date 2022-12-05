using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using IST.RRHH;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Model;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH.Web.Models;

namespace IST.RRHH.Web.Controllers
{   

	[Authorize()]
	public class TipoNotificacionController : Controller
    {

		IMediator Mediator; 
        ICustomUserContext UserLogin;
        IBDContext Context;

        public TipoNotificacionController(IMediator iMediator, ICustomUserContext iCustomUserContext, IBDContext iBDContext) {
            this.Mediator = iMediator; 
            this.UserLogin = iCustomUserContext;
            this.Context = iBDContext; 
        }

		// Index

		public ActionResult Index()
		{
			var model = new TipoNotificacionViewModel { };			
			PrepareIndexModel(model);
			return View(model);
		}

		public void PrepareIndexModel(TipoNotificacionViewModel model)
		{
			 

			var request = Mediator.Query(new IST.RRHH.Domain.Query.TipoNotificacion.Index.GetAll.Query {});

			model.ListaTipoNotificacion = request.Select(c=> new TipoNotificacionViewModel
			{ 
											TipoNotificacionId = c.TipoNotificacionId , 
											   Nombre = c.Nombre , ContenidoPlantilla = c.ContenidoPlantilla
										}).ToList();
		}

		[HttpPost]
		public ActionResult Index(TipoNotificacionViewModel models)
		{		
			PrepareIndexModel(models);
			return View(models);
		}

		// Create
		public ActionResult Create()
		{
			var model = new TipoNotificacionViewModel { };			
			return View(model);
		}

		[HttpPost]
		public ActionResult Create(TipoNotificacionViewModel model)
		{
			try
			{
				


				var command = new IST.RRHH.Domain.Command.TipoNotificacion.Create.Command {
										TipoNotificacionId = model.TipoNotificacionId , 
											   Nombre = model.Nombre, ContenidoPlantilla = model.ContenidoPlantilla 
				};

				Mediator.Command(command);
				TempData["Success"] = "Item creado exitosamente";
				return RedirectToAction("Index");
			}
			catch(Exception ex)
			{
				TempData["Error"] = ex.Message;
				return View(model);
			}
		}

		//Edits

		public ActionResult Edit(int id)
		{

			var query = new IST.RRHH.Domain.Query.TipoNotificacion.Edit.GetSingleItem.Query {
				TipoNotificacionId = id
			};

			var model = Mediator.Query(query);

			var modelView = new TipoNotificacionViewModel
			{
									TipoNotificacionId = model.TipoNotificacionId , 
											   Nombre = model.Nombre, ContenidoPlantilla = model.ContenidoPlantilla								
								};

			return View(modelView);
		}


		[HttpPost]
		public ActionResult Edit(TipoNotificacionViewModel model)
		{
			try
			{
				var command = new IST.RRHH.Domain.Command.TipoNotificacion.Edit.Command {
					TipoNotificacionId = model.TipoNotificacionId , 
											   Nombre = model.Nombre , ContenidoPlantilla = model.ContenidoPlantilla
									};

				Mediator.Command(command);
				TempData["Success"] = "Item actualizado exitosamente";
				return RedirectToAction("Index");
			}
			catch(Exception ex)
			{
				TempData["Error"] = ex.Message;
				return View(model);
			}
		}

		//Delete

		public ActionResult Delete(int id)
		{
			try
			{

				var command = new IST.RRHH.Domain.Command.TipoNotificacion.Delete.Command {
				TipoNotificacionId = id
				};			

				Mediator.Command(command);

				TempData["Success"] = "Item eliminado exitosamente";
				return RedirectToAction("Index");

				
			}
			catch(Exception ex)
			{
				TempData["Error"] = ex.Message;
				return RedirectToAction("Index");
			}
		
		}

		//Details

		public ActionResult Details(string id)
		{

			var query = new IST.RRHH.Domain.Query.TipoNotificacion.Edit.GetSingleItem.Query {
				
						};

			var model = Mediator.Query(query);

			var modelView = new Models.TipoNotificacion.EditViewModel {
									TipoNotificacionId = model.TipoNotificacionId , 
											   Nombre = model.Nombre 								
							};

			return View(modelView);
		}
			
	}
} 
