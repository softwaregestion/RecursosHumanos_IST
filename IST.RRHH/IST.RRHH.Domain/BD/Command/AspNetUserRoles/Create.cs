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
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  string UserId  {get; set;} 			
			//Soy PK  
			public  string RoleId  {get; set;} 			
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

				var item = new Model.AspNetUserRoles();

			
				//Soy PK  
				item.UserId  = command.UserId; 			
				//Soy PK  
				item.RoleId  = command.RoleId; 				

				context.AspNetUserRoles.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


