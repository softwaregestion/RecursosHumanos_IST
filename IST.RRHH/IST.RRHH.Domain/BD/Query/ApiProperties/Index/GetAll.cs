// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.ApiProperties.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  string Key  {get;set;}
			public  string Value  {get;set;}
			public  int ApiResourceId  {get;set;}
					
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

                var queriedItem = context.ApiProperties.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   Key = c.Key , 
											   Value = c.Value , 
											   ApiResourceId = c.ApiResourceId });				

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

