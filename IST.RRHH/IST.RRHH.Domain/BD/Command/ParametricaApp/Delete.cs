// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Command.ParametricaApp
{   
    

	public class Delete
    {
        public class Command : ICommand
        {	
				public  int ParametricaId  {get;set;}
							
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
                
				var item = context.ParametricaApp.SingleOrDefault(c => 
					 c.ParametricaId == command.ParametricaId
				);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");
 
                context.ParametricaApp.Remove(item);
                 
                context.SaveChanges();
              
            }
        }
    }
}


