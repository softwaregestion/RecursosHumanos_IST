// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.IdentityProperties
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK 			
			//Soy IsAutoIncrement  
			public  int Id  {get; set;}  
			public  string Key  {get; set;}  
			public  string Value  {get; set;}  
			public  int IdentityResourceId  {get; set;} 			
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

				var item = new Model.IdentityProperties();

 
				item.Key  = command.Key;  
				item.Value  = command.Value;  
				item.IdentityResourceId  = command.IdentityResourceId; 				

				context.IdentityProperties.Add(item);
                
                context.SaveChanges();
			
		//IsAutoIncrement
				command.Id  = item.Id; 			
				
            }
        }
    }
}


