// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.AspNetUsers.Index
{   
    

	public class GetAllByIds
	{

		public class Result
		{
			public  string Id  {get;set;}
			public  int AccessFailedCount  {get;set;}
			public  string ConcurrencyStamp  {get;set;}
			public  string Email  {get;set;}
			public  bool EmailConfirmed  {get;set;}
			public  bool LockoutEnabled  {get;set;}
			public  DateTimeOffset? LockoutEnd  {get;set;}
			public  string NormalizedEmail  {get;set;}
			public  string NormalizedUserName  {get;set;}
			public  string PasswordHash  {get;set;}
			public  string PhoneNumber  {get;set;}
			public  bool PhoneNumberConfirmed  {get;set;}
			public  string SecurityStamp  {get;set;}
			public  bool TwoFactorEnabled  {get;set;}
			public  string UserName  {get;set;}
					
		}

        public class Query : IQuery<List<Result>>
        {
        	public List<string>	Ids { get; set; }
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

                var queriedItem = context.AspNetUsers.Where(c=> query.Ids.Contains(c.Id)).ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   AccessFailedCount = c.AccessFailedCount , 
											   ConcurrencyStamp = c.ConcurrencyStamp , 
											   Email = c.Email , 
											   EmailConfirmed = c.EmailConfirmed , 
											   LockoutEnabled = c.LockoutEnabled , 
											   LockoutEnd = c.LockoutEnd , 
											   NormalizedEmail = c.NormalizedEmail , 
											   NormalizedUserName = c.NormalizedUserName , 
											   PasswordHash = c.PasswordHash , 
											   PhoneNumber = c.PhoneNumber , 
											   PhoneNumberConfirmed = c.PhoneNumberConfirmed , 
											   SecurityStamp = c.SecurityStamp , 
											   TwoFactorEnabled = c.TwoFactorEnabled , 
											   UserName = c.UserName });				

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


