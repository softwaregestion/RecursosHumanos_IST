using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using IST.RRHH.Model.Common;


namespace IST.RRHH.Web.Models.TipoNotificacion
{   

	public class IndexModel
	{
		public List<TipoNotificacion> Items {get; set;}
			
		public Paginado PaginacionView {get; set;}
		
		public TipoNotificacion ParametrosView {get; set;}     

		

		public class TipoNotificacion
		{

 
			[Display(Name = "TipoNotificacionId")]	
			public  int TipoNotificacionId  {get; set;}
		 
			[Display(Name = "Nombre")]	
			public  string Nombre  {get; set;}
				}	
	}
} 
