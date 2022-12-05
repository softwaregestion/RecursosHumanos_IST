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

namespace IST.RRHH.Domain.Query.TipoNotificacion.Details
{   
    

	public class GetSingleItem
    {

		public class Result
		{
			public  int TipoNotificacionId  {get;set;}
			public  string Nombre  {get;set;}
			public  string ContenidoPlantilla  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  int TipoNotificacionId  {get;set;}
				
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

				  
				var queriedItem = context.TipoNotificacion.SingleOrDefault(c => 
					 c.TipoNotificacionId == query.TipoNotificacionId
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.TipoNotificacionId  = queriedItem.TipoNotificacionId; 			
				result.Nombre  = queriedItem.Nombre; 			
				result.ContenidoPlantilla  = queriedItem.ContenidoPlantilla; 

			    return result;				
            }
        }
    }
}


