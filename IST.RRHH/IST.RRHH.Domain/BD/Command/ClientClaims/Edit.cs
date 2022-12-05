// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.ClientClaims
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  string Type  {get; set;} 			
			public  string Value  {get; set;} 			
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
				var item = context.ClientClaims.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Type  = command.Type; 			
				item.Value  = command.Value; 			
				item.ClientId  = command.ClientId; 				

				//context.ClientClaims.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


