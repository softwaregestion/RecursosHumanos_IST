// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.ApiScopeClaims.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  string Type  {get;set;}
			public  int ApiScopeId  {get;set;}
		
			
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

				  
				var queriedItem = context.ApiScopeClaims.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.Type  = queriedItem.Type; 			
				result.ApiScopeId  = queriedItem.ApiScopeId; 

			    return result;				
            }
        }
    

	
    }
}


