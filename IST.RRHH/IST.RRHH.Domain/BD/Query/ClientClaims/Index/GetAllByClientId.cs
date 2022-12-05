// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.ClientClaims.Index
{   
    

	public class GetAllByClientId
	{

		public class Result
		{
			public int Id { get; set; }
			public string Type { get; set; }
			public string Value { get; set; }
			public int ClientId { get; set; }

		}

		public class Query : IQuery<List<Result>>
        {
        		
			public Paginado QueryRequest {get; set;}
            public  int ClientId { get;  set; }
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

                var queriedItem = context.ClientClaims.Where(c=> query.ClientId == c.ClientId).ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id ,
																		Type = c.Type,
																		Value = c.Value,
																		ClientId = c.ClientId
																	});				

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


