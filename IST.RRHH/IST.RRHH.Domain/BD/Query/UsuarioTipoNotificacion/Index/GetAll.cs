// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.UsuarioTipoNotificacion.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  string UserId  {get;set;}
			public  int TipoNotificacionId  {get;set;}
			public  DateTime UltimaModificacion  {get;set;}
			public  string UsuarioModificacion  {get;set;}
					
		}

        public class Query : IQuery<List<Result>>
        {
        		
			public Paginado QueryRequest {get; set;}
				
        }
 
        public class Handler : IQueryHandler<Query, List<Result>>
        {
            IBDContext context;
 
            public Handler(IBDContext context)
            {
                this.context = context;
            }
 
            public List<Result> Handle(Query query)
            {
				var result = new List<Result>();

                var queriedItem = context.UsuarioTipoNotificacion.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { UserId = c.UserId , 
											   TipoNotificacionId = c.TipoNotificacionId , 
											   UltimaModificacion = c.UltimaModificacion , 
											   UsuarioModificacion = c.UsuarioModificacion });				

				if(query.QueryRequest != null)
				{
                    result = orderedResults.AsQueryable().GetPageItems(query.QueryRequest);
                }	
				else {
					result = orderedResults.ToList();
				}				

			    return result;							
            }
        }
    }
}


