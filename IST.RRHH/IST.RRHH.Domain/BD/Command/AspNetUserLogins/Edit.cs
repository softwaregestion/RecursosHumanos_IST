// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.AspNetUserLogins
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  string LoginProvider  {get; set;} 			
			public  string ProviderKey  {get; set;} 			
			public  string ProviderDisplayName  {get; set;} 			
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
				var item = context.AspNetUserLogins.SingleOrDefault(c => 
						 c.LoginProvider == command.LoginProvider && c.ProviderKey == command.ProviderKey
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.ProviderDisplayName  = command.ProviderDisplayName; 			
				item.UserId  = command.UserId; 				

				//context.AspNetUserLogins.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


