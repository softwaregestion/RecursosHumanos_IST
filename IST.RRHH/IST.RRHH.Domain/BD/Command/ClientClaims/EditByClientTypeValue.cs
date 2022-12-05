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
    

	public class EditByClientTypeValue
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  string ClaimType  {get; set;} 			
			public  string ClaimValue  {get; set;} 			
			public  int ClientId { get; set;} 				
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
						 c.ClientId == command.ClientId && c.Type == command.ClaimType                         
				);

                if (command.ClaimValue == null)
                    command.ClaimValue = string.Empty;

                if (item == null)
                {
                    var itemnew = new Model.ClientClaims();

                    itemnew.Type = command.ClaimType;
                    itemnew.Value = command.ClaimValue;
                    itemnew.ClientId = command.ClientId;
                    context.ClientClaims.Add(itemnew);
                }
                else {
                    item.Value = command.ClaimValue;
                }
					

				
                
                context.SaveChanges();
               
            }
        }
    }
}


