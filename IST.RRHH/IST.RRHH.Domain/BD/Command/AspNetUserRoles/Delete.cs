// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Command.AspNetUserRoles
{   
    

	public class Delete
    {
        public class Command : ICommand
        {	
				public  string UserId  {get;set;}
				public  string RoleId  {get;set;}
							
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
                
				var item = context.AspNetUserRoles.SingleOrDefault(c => 
					 c.UserId == command.UserId && c.RoleId == command.RoleId
				);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");
 
                context.AspNetUserRoles.Remove(item);
                 
                context.SaveChanges();
              
            }
        }
    }
}


