// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.UsuarioTipoNotificacion
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  string UserId  {get; set;} 			
			//Soy PK  
			public  int TipoNotificacionId  {get; set;}  
			public  DateTime UltimaModificacion  {get; set;}  
			public  string UsuarioModificacion  {get; set;} 			
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

				var item = new Model.UsuarioTipoNotificacion();

			
				//Soy PK  
				item.UserId  = command.UserId; 			
				//Soy PK  
				item.TipoNotificacionId  = command.TipoNotificacionId;  
				item.UltimaModificacion  = command.UltimaModificacion;  
				item.UsuarioModificacion  = command.UsuarioModificacion; 				

				context.UsuarioTipoNotificacion.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


