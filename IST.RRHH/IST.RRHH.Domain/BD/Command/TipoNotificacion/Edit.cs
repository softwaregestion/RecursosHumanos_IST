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
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
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
				var item = context.TipoNotificacion.SingleOrDefault(c => 
						 c.TipoNotificacionId == command.TipoNotificacionId
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Nombre  = command.Nombre; 			
				item.ContenidoPlantilla  = command.ContenidoPlantilla; 				

				//context.TipoNotificacion.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


