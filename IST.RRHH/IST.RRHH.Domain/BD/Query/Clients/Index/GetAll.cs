// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.Clients.Index
{   
	public class GetAll
    {

		public class Result
		{
			public  int Id  {get;set;}
			public  bool Enabled  {get;set;}
			public  string ClientId  {get;set;}
			public  string ProtocolType  {get;set;}
			public  bool RequireClientSecret  {get;set;}
			public  string ClientName  {get;set;}
			public  string Description  {get;set;}
			public  string ClientUri  {get;set;}
			public  string LogoUri  {get;set;}
			public  bool RequireConsent  {get;set;}
			public  bool AllowRememberConsent  {get;set;}
			public  bool AlwaysIncludeUserClaimsInIdToken  {get;set;}
			public  bool RequirePkce  {get;set;}
			public  bool AllowPlainTextPkce  {get;set;}
			public  bool AllowAccessTokensViaBrowser  {get;set;}
			public  string FrontChannelLogoutUri  {get;set;}
			public  bool FrontChannelLogoutSessionRequired  {get;set;}
			public  string BackChannelLogoutUri  {get;set;}
			public  bool BackChannelLogoutSessionRequired  {get;set;}
			public  bool AllowOfflineAccess  {get;set;}
			public  int IdentityTokenLifetime  {get;set;}
			public  int AccessTokenLifetime  {get;set;}
			public  int AuthorizationCodeLifetime  {get;set;}
			public  int? ConsentLifetime  {get;set;}
			public  int AbsoluteRefreshTokenLifetime  {get;set;}
			public  int SlidingRefreshTokenLifetime  {get;set;}
			public  int RefreshTokenUsage  {get;set;}
			public  bool UpdateAccessTokenClaimsOnRefresh  {get;set;}
			public  int RefreshTokenExpiration  {get;set;}
			public  int AccessTokenType  {get;set;}
			public  bool EnableLocalLogin  {get;set;}
			public  bool IncludeJwtId  {get;set;}
			public  bool AlwaysSendClientClaims  {get;set;}
			public  string ClientClaimsPrefix  {get;set;}
			public  string PairWiseSubjectSalt  {get;set;}
			public  DateTime Created  {get;set;}
			public  DateTime? Updated  {get;set;}
			public  DateTime? LastAccessed  {get;set;}
			public  int? UserSsoLifetime  {get;set;}
			public  string UserCodeType  {get;set;}
			public  int DeviceCodeLifetime  {get;set;}
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

                var queriedItem = context.Clients.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { Id = c.Id , 
											   Enabled = c.Enabled , 
											   ClientId = c.ClientId , 
											   ProtocolType = c.ProtocolType , 
											   RequireClientSecret = c.RequireClientSecret , 
											   ClientName = c.ClientName , 
											   Description = c.Description , 
											   ClientUri = c.ClientUri , 
											   LogoUri = c.LogoUri , 
											   RequireConsent = c.RequireConsent , 
											   AllowRememberConsent = c.AllowRememberConsent , 
											   AlwaysIncludeUserClaimsInIdToken = c.AlwaysIncludeUserClaimsInIdToken , 
											   RequirePkce = c.RequirePkce , 
											   AllowPlainTextPkce = c.AllowPlainTextPkce , 
											   AllowAccessTokensViaBrowser = c.AllowAccessTokensViaBrowser , 
											   FrontChannelLogoutUri = c.FrontChannelLogoutUri , 
											   FrontChannelLogoutSessionRequired = c.FrontChannelLogoutSessionRequired , 
											   BackChannelLogoutUri = c.BackChannelLogoutUri , 
											   BackChannelLogoutSessionRequired = c.BackChannelLogoutSessionRequired , 
											   AllowOfflineAccess = c.AllowOfflineAccess , 
											   IdentityTokenLifetime = c.IdentityTokenLifetime , 
											   AccessTokenLifetime = c.AccessTokenLifetime , 
											   AuthorizationCodeLifetime = c.AuthorizationCodeLifetime , 
											   ConsentLifetime = c.ConsentLifetime , 
											   AbsoluteRefreshTokenLifetime = c.AbsoluteRefreshTokenLifetime , 
											   SlidingRefreshTokenLifetime = c.SlidingRefreshTokenLifetime , 
											   RefreshTokenUsage = c.RefreshTokenUsage , 
											   UpdateAccessTokenClaimsOnRefresh = c.UpdateAccessTokenClaimsOnRefresh , 
											   RefreshTokenExpiration = c.RefreshTokenExpiration , 
											   AccessTokenType = c.AccessTokenType , 
											   EnableLocalLogin = c.EnableLocalLogin , 
											   IncludeJwtId = c.IncludeJwtId , 
											   AlwaysSendClientClaims = c.AlwaysSendClientClaims , 
											   ClientClaimsPrefix = c.ClientClaimsPrefix , 
											   PairWiseSubjectSalt = c.PairWiseSubjectSalt , 
											   Created = c.Created , 
											   Updated = c.Updated , 
											   LastAccessed = c.LastAccessed , 
											   UserSsoLifetime = c.UserSsoLifetime , 
											   UserCodeType = c.UserCodeType , 
											   DeviceCodeLifetime = c.DeviceCodeLifetime , 
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


