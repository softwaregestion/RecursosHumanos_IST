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
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  string UserId  {get; set;} 			
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
				var item = context.UsuarioTipoNotificacion.SingleOrDefault(c => 
						 c.UserId == command.UserId && c.TipoNotificacionId == command.TipoNotificacionId
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.UltimaModificacion  = command.UltimaModificacion; 			
				item.UsuarioModificacion  = command.UsuarioModificacion; 				

				//context.UsuarioTipoNotificacion.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


