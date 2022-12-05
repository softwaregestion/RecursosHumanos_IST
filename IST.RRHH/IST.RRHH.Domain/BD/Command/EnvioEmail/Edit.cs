// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.EnvioEmail
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  bool Enviado  {get; set;} 			
			public  string Para  {get; set;} 			
			public  string Mensaje  {get; set;} 			
			public  string Obj  {get; set;} 			
			public  DateTime? Fechacreacion  {get; set;} 			
			public  DateTime? Fechaenvio  {get; set;} 			
			public  string Asunto  {get; set;} 			
			public  string ConCopia  {get; set;} 			
			public  string ConCopiaOculta  {get; set;} 			
			public  string Tipo  {get; set;} 				
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
				var item = context.EnvioEmail.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Enviado  = command.Enviado; 			
				item.Para  = command.Para; 			
				item.Mensaje  = command.Mensaje; 			
				item.Obj  = command.Obj; 			
				item.Fechacreacion  = command.Fechacreacion; 			
				item.Fechaenvio  = command.Fechaenvio; 			
				item.Asunto  = command.Asunto; 			
				item.ConCopia  = command.ConCopia; 			
				item.ConCopiaOculta  = command.ConCopiaOculta; 			
				item.Tipo  = command.Tipo; 				

				//context.EnvioEmail.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


