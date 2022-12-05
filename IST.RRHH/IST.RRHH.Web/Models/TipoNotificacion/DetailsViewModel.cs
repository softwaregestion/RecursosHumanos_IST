using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace IST.RRHH.Web.Models.TipoNotificacion
{   
	public class DetailsViewModel
    {

 
		[Display(Name = "TipoNotificacionId")]	
		public  int TipoNotificacionId  {get; set;}
		 
		[Display(Name = "Nombre")]	
		public  string Nombre  {get; set;}
					
	}
} 
