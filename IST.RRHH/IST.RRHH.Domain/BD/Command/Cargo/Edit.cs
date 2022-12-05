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
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
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
				var item = context.Cargo.SingleOrDefault(c => 
						 c.CargoID == command.CargoId
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Nombre  = command.Nombre; 				

				//context.Cargo.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


