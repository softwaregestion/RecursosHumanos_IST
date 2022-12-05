// **********************************
// **********************************
// **********************************
using IST.RRHH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace IST.RRHH.Domain.Command.AspNetUsers
{   
    

	public class EditEstados
	{
        public class Command : ICommand
        {		
			
			public  string Id  {get; set;} 					
			public  bool LockoutEnabled  {get; set;} 	
			public  bool TwoFactorEnabled  {get; set;} 			
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
				var item = context.AspNetUsers.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
						
				item.LockoutEnabled  = command.LockoutEnabled; 			
				item.TwoFactorEnabled  = command.TwoFactorEnabled; 			
				
				
                
                context.SaveChanges();
               
            }
        }
    }
}


