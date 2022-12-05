// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.ApiSecrets
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  string Description  {get; set;} 			
			public  string Value  {get; set;} 			
			public  DateTime? Expiration  {get; set;} 			
			public  string Type  {get; set;} 			
			public  DateTime Created  {get; set;} 			
			public  int ApiResourceId  {get; set;} 				
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
				var item = context.ApiSecrets.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Description  = command.Description; 			
				item.Value  = command.Value; 			
				item.Expiration  = command.Expiration; 			
				item.Type  = command.Type; 			
				item.Created  = command.Created; 			
				item.ApiResourceId  = command.ApiResourceId; 				

				//context.ApiSecrets.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


