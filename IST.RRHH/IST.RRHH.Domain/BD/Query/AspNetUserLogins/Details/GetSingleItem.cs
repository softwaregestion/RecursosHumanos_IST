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

namespace IST.RRHH.Domain.Query.AspNetUserLogins.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  string LoginProvider  {get;set;}
			public  string ProviderKey  {get;set;}
			public  string ProviderDisplayName  {get;set;}
			public  string UserId  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  string LoginProvider  {get;set;}
			public  string ProviderKey  {get;set;}
				
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

				  
				var queriedItem = context.AspNetUserLogins.SingleOrDefault(c => 
					 c.LoginProvider == query.LoginProvider && c.ProviderKey == query.ProviderKey
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.LoginProvider  = queriedItem.LoginProvider; 			
				result.ProviderKey  = queriedItem.ProviderKey; 			
				result.ProviderDisplayName  = queriedItem.ProviderDisplayName; 			
				result.UserId  = queriedItem.UserId; 

			    return result;				
            }
        }
    }
}


