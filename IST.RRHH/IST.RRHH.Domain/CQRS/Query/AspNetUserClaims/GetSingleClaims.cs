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

namespace IST.RRHH.Domain.Query.AspNetUserClaims.Details
{   
    

	public class GetSingleClaims
	{

		public class Result
		{
			public  int Id  {get;set;}
			public  string ClaimType  {get;set;}
			public  string ClaimValue  {get;set;}
			public  string UserId  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public string ClaimType { get; set; }
			public string UserId { get; set; }

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

				  
				var queriedItem = context.AspNetUserClaims.SingleOrDefault(c => 
					 c.ClaimType == query.ClaimType && c.UserId == query.UserId
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.ClaimType  = queriedItem.ClaimType; 			
				result.ClaimValue  = queriedItem.ClaimValue; 			
				result.UserId  = queriedItem.UserId; 

			    return result;				
            }
        }
    }
}


