using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace IST.RRHH.Web.Models.UsuarioTipoNotificacion
{   
	public class DetailsViewModel
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
