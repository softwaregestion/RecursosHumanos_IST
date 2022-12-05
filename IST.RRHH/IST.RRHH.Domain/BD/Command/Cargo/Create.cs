// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.Cargo
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  int CargoId  {get; set;}  
			public  string Nombre  {get; set;} 			
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

				var item = new Model.Cargo();

			
				//Soy PK  
				item.CargoID = command.CargoId;  
				item.Nombre  = command.Nombre; 				

				context.Cargo.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


