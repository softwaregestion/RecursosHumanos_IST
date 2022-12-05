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
    

	public class EditByUserTypeValue
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
						 c.UserId == command.UserId && c.ClaimType == command.ClaimType                         
				);

                if (command.ClaimValue == null)
                    command.ClaimValue = string.Empty;

                if (item == null)
                {
                    var itemnew = new Model.AspNetUserClaims();

                    itemnew.ClaimType = command.ClaimType;
                    itemnew.ClaimValue = command.ClaimValue;
                    itemnew.UserId = command.UserId;
                    context.AspNetUserClaims.Add(itemnew);
                }
                else {
                    item.ClaimValue = command.ClaimValue;
                }
					

				
                
                context.SaveChanges();
               
            }
        }
    }
}


