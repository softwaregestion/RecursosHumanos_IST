// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Command.Cargo
{   
    

	public class Delete
    {
        public class Command : ICommand
        {	
				public  int CargoId  {get;set;}
							
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
                
				var item = context.Cargo.SingleOrDefault(c => 
					 c.CargoID == command.CargoId
				);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");
 
                context.Cargo.Remove(item);
                 
                context.SaveChanges();
              
            }
        }
    }
}


