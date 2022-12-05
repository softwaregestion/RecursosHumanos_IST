// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.UsuarioTipoNotificacion.Edit
{   
    public class GetSingleItem
    {

		public class Result
		{
			public  string UserId  {get;set;}
			public  int TipoNotificacionId  {get;set;}
			public  DateTime UltimaModificacion  {get;set;}
			public  string UsuarioModificacion  {get;set;}
		
			
		}

        public class Query : IQuery<Result>
        {        		
			public  string UserId  {get;set;}
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

				  
				var queriedItem = context.UsuarioTipoNotificacion.SingleOrDefault(c => 
					 c.UserId == query.UserId && c.TipoNotificacionId == query.TipoNotificacionId
				);

				
				if (queriedItem == null)
					throw new BusinessException("El ítem no existe");

				var result = new Result();

							
				result.UserId  = queriedItem.UserId; 			
				result.TipoNotificacionId  = queriedItem.TipoNotificacionId; 			
				result.UltimaModificacion  = queriedItem.UltimaModificacion; 			
				result.UsuarioModificacion  = queriedItem.UsuarioModificacion; 

			    return result;				
            }
        }
    

	
    }
}


