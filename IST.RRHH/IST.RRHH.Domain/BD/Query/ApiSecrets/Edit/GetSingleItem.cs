// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.ApiSecrets.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  string Description  {get;set;}
			public  string Value  {get;set;}
			public  DateTime? Expiration  {get;set;}
			public  string Type  {get;set;}
			public  DateTime Created  {get;set;}
			public  int ApiResourceId  {get;set;}
		
			
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

				  
				var queriedItem = context.ApiSecrets.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.Description  = queriedItem.Description; 			
				result.Value  = queriedItem.Value; 			
				result.Expiration  = queriedItem.Expiration; 			
				result.Type  = queriedItem.Type; 			
				result.Created  = queriedItem.Created; 			
				result.ApiResourceId  = queriedItem.ApiResourceId; 

			    return result;				
            }
        }
    

	
    }
}


