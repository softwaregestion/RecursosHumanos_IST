// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.AspNetUserClaims.Index
{   
    

	public class GetAllByNotClaimValue
	{

		public class Result
		{
			public  int Id  {get;set;}
			public  string ClaimType  {get;set;}
			public  string ClaimValue  {get;set;}
			public  string UserId  {get;set;}
					
		}

        public class Query : IQuery<List<Result>>
        {
			public Paginado QueryRequest {get; set;}
            public List<string> ClaimValue { get;  set; }
			public string ClaimType { get; set; }
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

                var queriedItem = context.AspNetUserClaims.Where(c=> !query.ClaimValue.Contains(c.ClaimValue) && c.ClaimType != query.ClaimType).ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   ClaimType = c.ClaimType , 
											   ClaimValue = c.ClaimValue , 
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


