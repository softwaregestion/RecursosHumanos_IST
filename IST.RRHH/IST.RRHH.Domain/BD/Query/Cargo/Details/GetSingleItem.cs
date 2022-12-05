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

namespace IST.RRHH.Domain.Query.Cargo.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  int CargoId  {get;set;}
			public  string Nombre  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  int CargoId  {get;set;}
				
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

				  
				var queriedItem = context.Cargo.SingleOrDefault(c => 
					 c.CargoID == query.CargoId
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.CargoId  = queriedItem.CargoID; 			
				result.Nombre  = queriedItem.Nombre; 

			    return result;				
            }
        }
    }
}


