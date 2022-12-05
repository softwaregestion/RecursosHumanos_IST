// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.AspNetRoles.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  string Id  {get;set;}
			public  string ConcurrencyStamp  {get;set;}
			public  string Name  {get;set;}
			public  string NormalizedName  {get;set;}
					
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

                var queriedItem = context.AspNetRoles.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   ConcurrencyStamp = c.ConcurrencyStamp , 
											   Name = c.Name , 
											   NormalizedName = c.NormalizedName });				

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


