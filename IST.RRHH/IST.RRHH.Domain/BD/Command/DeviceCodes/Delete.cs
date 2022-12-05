// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Command.DeviceCodes
{   
    

	public class Delete
    {
        public class Command : ICommand
        {	
				public  string UserCode  {get;set;}
							
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
                
				var item = context.DeviceCodes.SingleOrDefault(c => 
					 c.UserCode == command.UserCode
				);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");
 
                context.DeviceCodes.Remove(item);
                 
                context.SaveChanges();
              
            }
        }
    }
}


