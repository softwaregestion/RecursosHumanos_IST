// **********************************
// **********************************
// **********************************
// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;

namespace IST.RRHH.Domain.Query.AspNetUsers.Details
{   
    

	public class GetSingleItem
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

        public class Query : IQuery<Result>
        {        		
			public  string Id  {get;set;}
				
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

				  
				var queriedItem = context.AspNetUsers.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.AccessFailedCount  = queriedItem.AccessFailedCount; 			
				result.ConcurrencyStamp  = queriedItem.ConcurrencyStamp; 			
				result.Email  = queriedItem.Email; 			
				result.EmailConfirmed  = queriedItem.EmailConfirmed; 			
				result.LockoutEnabled  = queriedItem.LockoutEnabled; 			
				result.LockoutEnd  = queriedItem.LockoutEnd; 			
				result.NormalizedEmail  = queriedItem.NormalizedEmail; 			
				result.NormalizedUserName  = queriedItem.NormalizedUserName; 			
				result.PasswordHash  = queriedItem.PasswordHash; 			
				result.PhoneNumber  = queriedItem.PhoneNumber; 			
				result.PhoneNumberConfirmed  = queriedItem.PhoneNumberConfirmed; 			
				result.SecurityStamp  = queriedItem.SecurityStamp; 			
				result.TwoFactorEnabled  = queriedItem.TwoFactorEnabled; 			
				result.UserName  = queriedItem.UserName; 

			    return result;				
            }
        }
    }
}


