// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.DeviceCodes
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  string UserCode  {get; set;}  
			public  string DeviceCode  {get; set;}  
			public  string SubjectId  {get; set;}  
			public  string ClientId  {get; set;}  
			public  DateTime CreationTime  {get; set;}  
			public  DateTime Expiration  {get; set;}  
			public  string Data  {get; set;} 			
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

				var item = new Model.DeviceCodes();

			
				//Soy PK  
				item.UserCode  = command.UserCode;  
				item.DeviceCode  = command.DeviceCode;  
				item.SubjectId  = command.SubjectId;  
				item.ClientId  = command.ClientId;  
				item.CreationTime  = command.CreationTime;  
				item.Expiration  = command.Expiration;  
				item.Data  = command.Data; 				

				context.DeviceCodes.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


