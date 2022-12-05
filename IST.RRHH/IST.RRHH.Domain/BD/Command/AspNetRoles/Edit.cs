// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.AspNetRoles
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  string Id  {get; set;} 			
			public  string ConcurrencyStamp  {get; set;} 			
			public  string Name  {get; set;} 			
			public  string NormalizedName  {get; set;} 				
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
				var item = context.AspNetRoles.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.ConcurrencyStamp  = command.ConcurrencyStamp; 			
				item.Name  = command.Name; 			
				item.NormalizedName  = command.NormalizedName; 				

				//context.AspNetRoles.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


