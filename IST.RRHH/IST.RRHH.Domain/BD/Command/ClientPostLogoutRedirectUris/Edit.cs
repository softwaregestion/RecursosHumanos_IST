// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.ClientPostLogoutRedirectUris
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  string PostLogoutRedirectUri  {get; set;} 			
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
				var item = context.ClientPostLogoutRedirectUris.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.PostLogoutRedirectUri  = command.PostLogoutRedirectUri; 			
				item.ClientId  = command.ClientId; 				

				//context.ClientPostLogoutRedirectUris.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


