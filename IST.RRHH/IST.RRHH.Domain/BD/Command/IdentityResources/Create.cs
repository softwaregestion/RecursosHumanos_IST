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
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK 			
			//Soy IsAutoIncrement  
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

				var item = new Model.IdentityResources();

 
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

				context.IdentityResources.Add(item);
                
                context.SaveChanges();
			
		//IsAutoIncrement
				command.Id  = item.Id; 			
				
            }
        }
    }
}


