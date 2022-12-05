// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.AspNetUserLogins
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  string LoginProvider  {get; set;} 			
			//Soy PK  
			public  string ProviderKey  {get; set;}  
			public  string ProviderDisplayName  {get; set;}  
			public  string UserId  {get; set;} 			
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

				var item = new Model.AspNetUserLogins();

			
				//Soy PK  
				item.LoginProvider  = command.LoginProvider; 			
				//Soy PK  
				item.ProviderKey  = command.ProviderKey;  
				item.ProviderDisplayName  = command.ProviderDisplayName;  
				item.UserId  = command.UserId; 				

				context.AspNetUserLogins.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


