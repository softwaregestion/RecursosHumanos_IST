// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.ApiScopes.Index
{   
	public class GetAll
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  string Name  {get;set;}
			public  string DisplayName  {get;set;}
			public  string Description  {get;set;}
			public  bool Required  {get;set;}
			public  bool Emphasize  {get;set;}
			public  bool ShowInDiscoveryDocument  {get;set;}
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

                var queriedItem = context.ApiScopes.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   Name = c.Name , 
											   DisplayName = c.DisplayName , 
											   Description = c.Description , 
											   Required = c.Required , 
											   Emphasize = c.Emphasize , 
											   ShowInDiscoveryDocument = c.ShowInDiscoveryDocument , 
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


