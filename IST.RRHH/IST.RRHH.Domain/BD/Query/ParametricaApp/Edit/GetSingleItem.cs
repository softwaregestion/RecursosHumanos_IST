// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.ParametricaApp.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  int ParametricaId  {get;set;}
			public  string Parametro  {get;set;}
			public  string Texto  {get;set;}
			public  string Valor  {get;set;}
			public  DateTime? FechaCreacion  {get;set;}
			public  bool? Activo  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  int ParametricaId  {get;set;}
				
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

				  
				var queriedItem = context.ParametricaApp.SingleOrDefault(c => 
					 c.ParametricaId == query.ParametricaId
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.ParametricaId  = queriedItem.ParametricaId; 			
				result.Parametro  = queriedItem.Parametro; 			
				result.Texto  = queriedItem.Texto; 			
				result.Valor  = queriedItem.Valor; 			
				result.FechaCreacion  = queriedItem.FechaCreacion; 			
				result.Activo  = queriedItem.Activo; 

			    return result;				
            }
        }
    

	
    }
}


