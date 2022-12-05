// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.AspNetUserClaims
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  string ClaimType  {get; set;} 			
			public  string ClaimValue  {get; set;} 			
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
				var item = context.AspNetUserClaims.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.ClaimType  = command.ClaimType; 			
				item.ClaimValue  = command.ClaimValue; 			
				item.UserId  = command.UserId; 				

				//context.AspNetUserClaims.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


