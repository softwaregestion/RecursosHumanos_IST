// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.PersistedGrants.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  string Key  {get;set;}
			public  string Type  {get;set;}
			public  string SubjectId  {get;set;}
			public  string ClientId  {get;set;}
			public  DateTime CreationTime  {get;set;}
			public  DateTime? Expiration  {get;set;}
			public  string Data  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  string Key  {get;set;}
				
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

				  
				var queriedItem = context.PersistedGrants.SingleOrDefault(c => 
					 c.Key == query.Key
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.Key  = queriedItem.Key; 			
				result.Type  = queriedItem.Type; 			
				result.SubjectId  = queriedItem.SubjectId; 			
				result.ClientId  = queriedItem.ClientId; 			
				result.CreationTime  = queriedItem.CreationTime; 			
				result.Expiration  = queriedItem.Expiration; 			
				result.Data  = queriedItem.Data; 

			    return result;				
            }
        }
    

	
    }
}


