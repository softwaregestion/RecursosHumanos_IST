// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.ParametricaApp
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK 			
			//Soy IsAutoIncrement  
			public  int ParametricaId  {get; set;}  
			public  string Parametro  {get; set;}  
			public  string Texto  {get; set;}  
			public  string Valor  {get; set;}  
			public  DateTime? FechaCreacion  {get; set;}  
			public  bool? Activo  {get; set;} 			
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

				var item = new Model.ParametricaApp();

 
				item.Parametro  = command.Parametro;  
				item.Texto  = command.Texto;  
				item.Valor  = command.Valor;  
				item.FechaCreacion  = command.FechaCreacion;  
				item.Activo  = command.Activo; 				

				context.ParametricaApp.Add(item);
                
                context.SaveChanges();
			
		//IsAutoIncrement
				command.ParametricaId  = item.ParametricaId; 			
				
            }
        }
    }
}


