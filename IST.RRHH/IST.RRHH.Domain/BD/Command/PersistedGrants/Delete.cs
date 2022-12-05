// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Command.PersistedGrants
{   
    

	public class Delete
    {
        public class Command : ICommand
        {	
				public  string Key  {get;set;}
							
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
                
				var item = context.PersistedGrants.SingleOrDefault(c => 
					 c.Key == command.Key
				);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");
 
                context.PersistedGrants.Remove(item);
                 
                context.SaveChanges();
              
            }
        }
    }
}


