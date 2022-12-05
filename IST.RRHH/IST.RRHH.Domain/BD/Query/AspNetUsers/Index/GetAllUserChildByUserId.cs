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
    

	public class GetAllUserChildByUserId
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
        	public string UserId { get; set; }
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

                try
                {
					List<string> user = new List<string>();

					var queriedRol = context.AspNetUserClaims.FirstOrDefault(c => c.UserId == query.UserId && c.ClaimType == "app_role.WorkSite");
					if (queriedRol != null)
					{
						var queriedClientId = context.AspNetUserClaims.FirstOrDefault(c => c.UserId == query.UserId && c.ClaimType == "clienteId");
						switch (queriedRol.ClaimValue)
						{
							case "Jacquard-Administrador":
								user = context.AspNetUsers.Select(c => c.Id).ToList();
							
								break;
							case "Jacquard-Operador":						
							case "Jacquard-Supervisor":
							case "Cliente-Gestión":
							case "Cliente-Supervisor":

								var queriedClient = context.AspNetUserClaims.Where(c => c.ClaimValue == queriedClientId.ClaimValue && c.ClaimType == "clienteId");
								user = queriedClient.Select(c => c.UserId).ToList();

								break;
							case "Cliente-Solicitante":

								user.Add(query.UserId);

								break;
						}
					}


					var orderedResults = this.context.AspNetUsers.Where(c=> user.Contains(c.Id)).Select(c=> new Result { Id = c.Id , 
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
												   UserName = c.UserName }).ToList();				

					if(orderedResults.Count > 0)
					{						
						result = orderedResults;
					}				

					return result;

				}
				catch (Exception)
				{

					return new List<Result>();
				}
			}
        }
    }
}


