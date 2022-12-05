// **********************************
// **********************************
// **********************************
// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.ClientIdPRestrictions.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  string Provider  {get;set;}
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

				  
				var queriedItem = context.ClientIdPRestrictions.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.Provider  = queriedItem.Provider; 			
				result.ClientId  = queriedItem.ClientId; 

			    return result;				
            }
        }
    }
}


