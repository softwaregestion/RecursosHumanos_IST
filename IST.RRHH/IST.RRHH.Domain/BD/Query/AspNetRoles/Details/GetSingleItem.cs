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

namespace IST.RRHH.Domain.Query.AspNetRoles.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  string Id  {get;set;}
			public  string ConcurrencyStamp  {get;set;}
			public  string Name  {get;set;}
			public  string NormalizedName  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  string Id  {get;set;}
				
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

				  
				var queriedItem = context.AspNetRoles.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.ConcurrencyStamp  = queriedItem.ConcurrencyStamp; 			
				result.Name  = queriedItem.Name; 			
				result.NormalizedName  = queriedItem.NormalizedName; 

			    return result;				
            }
        }
    }
}


