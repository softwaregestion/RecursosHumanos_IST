// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.TipoNotificacion
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK 			
			//Soy IsAutoIncrement  
			public  int TipoNotificacionId  {get; set;}  
			public  string Nombre  {get; set;}  
			public  string ContenidoPlantilla  {get; set;} 			
        }
 
        public class Handler : ICommandHandler<Command>
        {
            IBDContext context;
 
             public Handler(IBDContext context)
            {
                this.context = context;
            }
 
            public void Handle(Command command)
            {

				var item = new Model.TipoNotificacion();

 
				item.Nombre  = command.Nombre;  
				item.ContenidoPlantilla  = command.ContenidoPlantilla; 				

				context.TipoNotificacion.Add(item);
                
                context.SaveChanges();
			
		//IsAutoIncrement
				command.TipoNotificacionId  = item.TipoNotificacionId; 			
				
            }
        }
    }
}


