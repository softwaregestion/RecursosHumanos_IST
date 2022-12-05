// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.EnvioEmail.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  bool Enviado  {get;set;}
			public  string Para  {get;set;}
			public  string Mensaje  {get;set;}
			public  string Obj  {get;set;}
			public  DateTime? Fechacreacion  {get;set;}
			public  DateTime? Fechaenvio  {get;set;}
			public  string Asunto  {get;set;}
			public  string ConCopia  {get;set;}
			public  string ConCopiaOculta  {get;set;}
			public  string Tipo  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  int Id  {get;set;}
				
        }
 
        public class Handler : IQueryHandler<Query, Result>
        {
            IBDContext context;
 
            public Handler(IBDContext context)
            {
                this.context = context;
            }
 
            public Result Handle(Query query)
            {

				  
				var queriedItem = context.EnvioEmail.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.Enviado  = queriedItem.Enviado; 			
				result.Para  = queriedItem.Para; 			
				result.Mensaje  = queriedItem.Mensaje; 			
				result.Obj  = queriedItem.Obj; 			
				result.Fechacreacion  = queriedItem.Fechacreacion; 			
				result.Fechaenvio  = queriedItem.Fechaenvio; 			
				result.Asunto  = queriedItem.Asunto; 			
				result.ConCopia  = queriedItem.ConCopia; 			
				result.ConCopiaOculta  = queriedItem.ConCopiaOculta; 			
				result.Tipo  = queriedItem.Tipo; 

			    return result;				
            }
        }
    

	
    }
}


