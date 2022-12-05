// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.ClientPostLogoutRedirectUris.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  string PostLogoutRedirectUri  {get;set;}
			public  int ClientId  {get;set;}
		
			
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

				  
				var queriedItem = context.ClientPostLogoutRedirectUris.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.PostLogoutRedirectUri  = queriedItem.PostLogoutRedirectUri; 			
				result.ClientId  = queriedItem.ClientId; 

			    return result;				
            }
        }
    

	
    }
}


