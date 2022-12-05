// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.ParametricaApp.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  int ParametricaId  {get;set;}
			public  string Parametro  {get;set;}
			public  string Texto  {get;set;}
			public  string Valor  {get;set;}
			public  DateTime? FechaCreacion  {get;set;}
			public  bool? Activo  {get;set;}
					
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

                var queriedItem = context.ParametricaApp.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { ParametricaId = c.ParametricaId , 
											   Parametro = c.Parametro , 
											   Texto = c.Texto , 
											   Valor = c.Valor , 
											   FechaCreacion = c.FechaCreacion , 
											   Activo = c.Activo });				

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


