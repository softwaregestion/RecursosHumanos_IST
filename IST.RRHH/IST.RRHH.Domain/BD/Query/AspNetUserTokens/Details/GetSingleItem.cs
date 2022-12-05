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

namespace IST.RRHH.Domain.Query.AspNetUserTokens.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  string UserId  {get;set;}
			public  string LoginProvider  {get;set;}
			public  string Name  {get;set;}
			public  string Value  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  string UserId  {get;set;}
			public  string LoginProvider  {get;set;}
			public  string Name  {get;set;}
				
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

				  
				var queriedItem = context.AspNetUserTokens.SingleOrDefault(c => 
					 c.UserId == query.UserId && c.LoginProvider == query.LoginProvider && c.Name == query.Name
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.UserId  = queriedItem.UserId; 			
				result.LoginProvider  = queriedItem.LoginProvider; 			
				result.Name  = queriedItem.Name; 			
				result.Value  = queriedItem.Value; 

			    return result;				
            }
        }
    }
}


