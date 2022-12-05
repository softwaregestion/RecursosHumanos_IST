// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.EnvioEmail.Index
{   
	public class GetAll
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  bool Enviado  {get;set;}
			public  string Para  {get;set;}
			public  string Mensaje  {get;set;}
			public  string Obj  {get;set;}
			public  DateTime? Fechacreacion  {get;set;}
			public  DateTime? Fechaenvio  {get;set;}
			public  string Asunto  {get;set;}
			public  string ConCopia  {get;set;}
			public  string ConCopiaOculta  {get;set;}
			public  string Tipo  {get;set;}
					
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

                var queriedItem = context.EnvioEmail.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   Enviado = c.Enviado , 
											   Para = c.Para , 
											   Mensaje = c.Mensaje , 
											   Obj = c.Obj , 
											   Fechacreacion = c.Fechacreacion , 
											   Fechaenvio = c.Fechaenvio , 
											   Asunto = c.Asunto , 
											   ConCopia = c.ConCopia , 
											   ConCopiaOculta = c.ConCopiaOculta , 
											   Tipo = c.Tipo });				

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


