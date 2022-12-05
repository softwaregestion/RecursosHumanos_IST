using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using IST.RRHH.Model.Common;


namespace IST.RRHH.Web.Models.UsuarioTipoNotificacion
{   

	public class IndexModel
	{
		public List<UsuarioTipoNotificacion> Items {get; set;}
			
		public Paginado PaginacionView {get; set;}
		
		public UsuarioTipoNotificacion ParametrosView {get; set;}     

		

		public class UsuarioTipoNotificacion
		{

 
			[Display(Name = "UserId")]	
			public  string UserId  {get; set;}
		 
			[Display(Name = "TipoNotificacionId")]	
			public  int TipoNotificacionId  {get; set;}
		 
			[Display(Name = "UltimaModificacion")]	
			public  DateTime UltimaModificacion  {get; set;}
		 
			[Display(Name = "UsuarioModificacion")]	
			public  string UsuarioModificacion  {get; set;}
				}	
	}
} 
