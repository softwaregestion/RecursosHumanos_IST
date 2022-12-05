// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.AspNetUserRoles.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  string UserId  {get;set;}
			public  string RoleId  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  string UserId  {get;set;}
			public  string RoleId  {get;set;}
				
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

				  
				var queriedItem = context.AspNetUserRoles.SingleOrDefault(c => 
					 c.UserId == query.UserId && c.RoleId == query.RoleId
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.UserId  = queriedItem.UserId; 			
				result.RoleId  = queriedItem.RoleId; 

			    return result;				
            }
        }
    

	
    }
}


