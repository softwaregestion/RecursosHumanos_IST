// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.IdentityResources
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  bool Enabled  {get; set;} 			
			public  string Name  {get; set;} 			
			public  string DisplayName  {get; set;} 			
			public  string Description  {get; set;} 			
			public  bool Required  {get; set;} 			
			public  bool Emphasize  {get; set;} 			
			public  bool ShowInDiscoveryDocument  {get; set;} 			
			public  DateTime Created  {get; set;} 			
			public  DateTime? Updated  {get; set;} 			
			public  bool NonEditable  {get; set;} 				
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
				var item = context.IdentityResources.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Enabled  = command.Enabled; 			
				item.Name  = command.Name; 			
				item.DisplayName  = command.DisplayName; 			
				item.Description  = command.Description; 			
				item.Required  = command.Required; 			
				item.Emphasize  = command.Emphasize; 			
				item.ShowInDiscoveryDocument  = command.ShowInDiscoveryDocument; 			
				item.Created  = command.Created; 			
				item.Updated  = command.Updated; 			
				item.NonEditable  = command.NonEditable; 				

				//context.IdentityResources.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


