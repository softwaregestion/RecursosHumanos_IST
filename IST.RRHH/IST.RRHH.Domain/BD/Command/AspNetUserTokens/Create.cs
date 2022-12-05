// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.AspNetUserTokens
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  string UserId  {get; set;} 			
			//Soy PK  
			public  string LoginProvider  {get; set;} 			
			//Soy PK  
			public  string Name  {get; set;}  
			public  string Value  {get; set;} 			
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

				var item = new Model.AspNetUserTokens();

			
				//Soy PK  
				item.UserId  = command.UserId; 			
				//Soy PK  
				item.LoginProvider  = command.LoginProvider; 			
				//Soy PK  
				item.Name  = command.Name;  
				item.Value  = command.Value; 				

				context.AspNetUserTokens.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


