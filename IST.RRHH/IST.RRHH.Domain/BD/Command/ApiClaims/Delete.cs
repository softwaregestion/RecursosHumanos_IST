// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Command.ApiClaims
{   
    

	public class Delete
    {
        public class Command : ICommand
        {	
				public  int Id  {get;set;}
							
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
                
				var item = context.ApiClaims.SingleOrDefault(c => 
					 c.Id == command.Id
				);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");
 
                context.ApiClaims.Remove(item);
                 
                context.SaveChanges();
              
            }
        }
    }
}


