// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.PersistedGrants
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  string Key  {get; set;} 			
			public  string Type  {get; set;} 			
			public  string SubjectId  {get; set;} 			
			public  string ClientId  {get; set;} 			
			public  DateTime CreationTime  {get; set;} 			
			public  DateTime? Expiration  {get; set;} 			
			public  string Data  {get; set;} 				
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
				var item = context.PersistedGrants.SingleOrDefault(c => 
						 c.Key == command.Key
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Type  = command.Type; 			
				item.SubjectId  = command.SubjectId; 			
				item.ClientId  = command.ClientId; 			
				item.CreationTime  = command.CreationTime; 			
				item.Expiration  = command.Expiration; 			
				item.Data  = command.Data; 				

				//context.PersistedGrants.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


