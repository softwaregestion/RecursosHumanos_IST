// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.ClientSecrets
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK 			
			//Soy IsAutoIncrement  
			public  int Id  {get; set;}  
			public  string Description  {get; set;}  
			public  string Value  {get; set;}  
			public  DateTime? Expiration  {get; set;}  
			public  string Type  {get; set;}  
			public  DateTime Created  {get; set;}  
			public  int ClientId  {get; set;} 			
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

				var item = new Model.ClientSecrets();

 
				item.Description  = command.Description;  
				item.Value  = command.Value;  
				item.Expiration  = command.Expiration;  
				item.Type  = command.Type;  
				item.Created  = command.Created;  
				item.ClientId  = command.ClientId; 				

				context.ClientSecrets.Add(item);
                
                context.SaveChanges();
			
		//IsAutoIncrement
				command.Id  = item.Id; 			
				
            }
        }
    }
}


