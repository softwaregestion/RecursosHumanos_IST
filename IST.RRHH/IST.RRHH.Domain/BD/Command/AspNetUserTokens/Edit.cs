// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.AspNetUserTokens
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  string UserId  {get; set;} 			
			public  string LoginProvider  {get; set;} 			
			public  string Name  {get; set;} 			
			public  string Value  {get; set;} 				
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
				var item = context.AspNetUserTokens.SingleOrDefault(c => 
						 c.UserId == command.UserId && c.LoginProvider == command.LoginProvider && c.Name == command.Name
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Value  = command.Value; 				

				//context.AspNetUserTokens.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


