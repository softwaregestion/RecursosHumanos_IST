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

namespace IST.RRHH.Domain.Query.ApiResources.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  bool Enabled  {get;set;}
			public  string Name  {get;set;}
			public  string DisplayName  {get;set;}
			public  string Description  {get;set;}
			public  DateTime Created  {get;set;}
			public  DateTime? Updated  {get;set;}
			public  DateTime? LastAccessed  {get;set;}
			public  bool NonEditable  {get;set;}
		
			
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

				  
				var queriedItem = context.ApiResources.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.Enabled  = queriedItem.Enabled; 			
				result.Name  = queriedItem.Name; 			
				result.DisplayName  = queriedItem.DisplayName; 			
				result.Description  = queriedItem.Description; 			
				result.Created  = queriedItem.Created; 			
				result.Updated  = queriedItem.Updated; 			
				result.LastAccessed  = queriedItem.LastAccessed; 			
				result.NonEditable  = queriedItem.NonEditable; 

			    return result;				
            }
        }
    }
}


