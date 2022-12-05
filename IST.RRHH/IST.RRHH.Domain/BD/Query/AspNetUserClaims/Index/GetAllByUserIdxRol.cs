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
    

	public class GetAllByUserIdxRol
	{

		public class Result
		{
			public  int Id  {get;set;}
			public  string ClaimType  {get;set;}
			public  string ClaimValue  {get;set;}
			public  string UserId  {get;set;}
					
		}

        public class Query : IQuery<Result>
        {
        		
			public Paginado QueryRequest {get; set;}
            public string UserId { get;  set; }
        }
 
        public class Handler : IQueryHandler<Query, Result>
        {
            IBDContext context;
 
            public Handler(IBDContext context)
            {
                this.context = context;
            }
 
            public Result Handle(Query query)
            {
				var result = new List<Result>();

                var queriedItem = context.AspNetUserClaims.Where(c=> c.UserId == query.UserId && c.ClaimType == "app_role.WorkSite").ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   ClaimType = c.ClaimType , 
											   ClaimValue = c.ClaimValue , 
											   UserId = c.UserId });				

				
			    return orderedResults.FirstOrDefault();							
            }
        }
    }
}


