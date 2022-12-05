// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.ApiResources.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  bool Enabled  {get;set;}
			public  string Name  {get;set;}
			public  string DisplayName  {get;set;}
			public  string Description  {get;set;}
			public  DateTime Created  {get;set;}
			public  DateTime? Updated  {get;set;}
			public  DateTime? LastAccessed  {get;set;}
			public  bool NonEditable  {get;set;}
					
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

                var queriedItem = context.ApiResources.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   Enabled = c.Enabled , 
											   Name = c.Name , 
											   DisplayName = c.DisplayName , 
											   Description = c.Description , 
											   Created = c.Created , 
											   Updated = c.Updated , 
											   LastAccessed = c.LastAccessed , 
											   NonEditable = c.NonEditable });				

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


