// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.AspNetUserLogins.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  string LoginProvider  {get;set;}
			public  string ProviderKey  {get;set;}
			public  string ProviderDisplayName  {get;set;}
			public  string UserId  {get;set;}
					
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

                var queriedItem = context.AspNetUserLogins.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { LoginProvider = c.LoginProvider , 
											   ProviderKey = c.ProviderKey , 
											   ProviderDisplayName = c.ProviderDisplayName , 
											   UserId = c.UserId });				

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


