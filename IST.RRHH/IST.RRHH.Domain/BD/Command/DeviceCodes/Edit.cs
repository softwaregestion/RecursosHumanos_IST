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
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
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
				var item = context.DeviceCodes.SingleOrDefault(c => 
						 c.UserCode == command.UserCode
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.DeviceCode  = command.DeviceCode; 			
				item.SubjectId  = command.SubjectId; 			
				item.ClientId  = command.ClientId; 			
				item.CreationTime  = command.CreationTime; 			
				item.Expiration  = command.Expiration; 			
				item.Data  = command.Data; 				

				//context.DeviceCodes.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


