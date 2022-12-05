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
 

namespace IST.RRHH.Web.Controllers
{   

	[Authorize()]
	public class UsuarioTipoNotificacionController : Controller
    {

		IMediator Mediator; 
        ICustomUserContext UserLogin;
        IBDContext Context;

        public UsuarioTipoNotificacionController(IMediator iMediator, ICustomUserContext iCustomUserContext, IBDContext iBDContext) {
            this.Mediator = iMediator; 
            this.UserLogin = iCustomUserContext;
            this.Context = iBDContext; 
        }

		// Index

		public ActionResult Index()
		{
			var model = new Models.UsuarioTipoNotificacion.IndexModel {};			
			PrepareIndexModel(model);
			return View(model);
		}

		public void PrepareIndexModel(Models.UsuarioTipoNotificacion.IndexModel model)
		{
			 

			var request = Mediator.Query(new IST.RRHH.Domain.Query.UsuarioTipoNotificacion.Index.GetAll.Query {});

			model.Items = request.Select(c=> new Models.UsuarioTipoNotificacion.IndexModel.UsuarioTipoNotificacion 
										{ 
											UserId = c.UserId , 
											   TipoNotificacionId = c.TipoNotificacionId , 
											   UltimaModificacion = c.UltimaModificacion , 
											   UsuarioModificacion = c.UsuarioModificacion 
										}).ToList();
		}

		[HttpPost]
		public ActionResult Index(Models.UsuarioTipoNotificacion.IndexModel models)
		{		
			PrepareIndexModel(models);
			return View(models);
		}

		// Create
		public ActionResult Create()
		{
			var model = new Models.UsuarioTipoNotificacion.CreateViewModel {};			
			return View(model);
		}

		[HttpPost]
		public ActionResult Create(Models.UsuarioTipoNotificacion.CreateViewModel model)
		{
			try
			{
				


				var command = new IST.RRHH.Domain.Command.UsuarioTipoNotificacion.Create.Command {
										UserId = model.UserId , 
											   TipoNotificacionId = model.TipoNotificacionId , 
											   UltimaModificacion = model.UltimaModificacion , 
											   UsuarioModificacion = model.UsuarioModificacion 
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

		public ActionResult Edit(string id)
		{

			var query = new IST.RRHH.Domain.Query.UsuarioTipoNotificacion.Edit.GetSingleItem.Query {
				
			};

			var model = Mediator.Query(query);

			var modelView = new Models.UsuarioTipoNotificacion.EditViewModel {
									UserId = model.UserId , 
											   TipoNotificacionId = model.TipoNotificacionId , 
											   UltimaModificacion = model.UltimaModificacion , 
											   UsuarioModificacion = model.UsuarioModificacion 								
								};

			return View(modelView);
		}


		[HttpPost]
		public ActionResult Edit(Models.UsuarioTipoNotificacion.EditViewModel model)
		{
			try
			{
				var command = new IST.RRHH.Domain.Command.UsuarioTipoNotificacion.Edit.Command {
					UserId = model.UserId , 
											   TipoNotificacionId = model.TipoNotificacionId , 
											   UltimaModificacion = model.UltimaModificacion , 
											   UsuarioModificacion = model.UsuarioModificacion 
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

		public ActionResult Delete(string id)
		{
			try
			{

				var command = new IST.RRHH.Domain.Command.UsuarioTipoNotificacion.Delete.Command {
				
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

			var query = new IST.RRHH.Domain.Query.UsuarioTipoNotificacion.Edit.GetSingleItem.Query {
				
						};

			var model = Mediator.Query(query);

			var modelView = new Models.UsuarioTipoNotificacion.EditViewModel {
									UserId = model.UserId , 
											   TipoNotificacionId = model.TipoNotificacionId , 
											   UltimaModificacion = model.UltimaModificacion , 
											   UsuarioModificacion = model.UsuarioModificacion 								
							};

			return View(modelView);
		}
			
	}
} 
