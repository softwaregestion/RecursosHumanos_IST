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
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
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
				var item = context.IdentityProperties.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Key  = command.Key; 			
				item.Value  = command.Value; 			
				item.IdentityResourceId  = command.IdentityResourceId; 				

				//context.IdentityProperties.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


