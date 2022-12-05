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

namespace IST.RRHH.Domain.Query.Clients.Details
{   
    

	public class GetSingleItem
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

        public class Query : IQuery<Result>
        {        		
			public  int Id  {get;set;}
				
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

				  
				var queriedItem = context.Clients.SingleOrDefault(c => 
					 c.Id == query.Id
				);

				
				if (queriedItem == null)
					return null;

				var result = new Result();

							
				result.Id  = queriedItem.Id; 			
				result.Enabled  = queriedItem.Enabled; 			
				result.ClientId  = queriedItem.ClientId; 			
				result.ProtocolType  = queriedItem.ProtocolType; 			
				result.RequireClientSecret  = queriedItem.RequireClientSecret; 			
				result.ClientName  = queriedItem.ClientName; 			
				result.Description  = queriedItem.Description; 			
				result.ClientUri  = queriedItem.ClientUri; 			
				result.LogoUri  = queriedItem.LogoUri; 			
				result.RequireConsent  = queriedItem.RequireConsent; 			
				result.AllowRememberConsent  = queriedItem.AllowRememberConsent; 			
				result.AlwaysIncludeUserClaimsInIdToken  = queriedItem.AlwaysIncludeUserClaimsInIdToken; 			
				result.RequirePkce  = queriedItem.RequirePkce; 			
				result.AllowPlainTextPkce  = queriedItem.AllowPlainTextPkce; 			
				result.AllowAccessTokensViaBrowser  = queriedItem.AllowAccessTokensViaBrowser; 			
				result.FrontChannelLogoutUri  = queriedItem.FrontChannelLogoutUri; 			
				result.FrontChannelLogoutSessionRequired  = queriedItem.FrontChannelLogoutSessionRequired; 			
				result.BackChannelLogoutUri  = queriedItem.BackChannelLogoutUri; 			
				result.BackChannelLogoutSessionRequired  = queriedItem.BackChannelLogoutSessionRequired; 			
				result.AllowOfflineAccess  = queriedItem.AllowOfflineAccess; 			
				result.IdentityTokenLifetime  = queriedItem.IdentityTokenLifetime; 			
				result.AccessTokenLifetime  = queriedItem.AccessTokenLifetime; 			
				result.AuthorizationCodeLifetime  = queriedItem.AuthorizationCodeLifetime; 			
				result.ConsentLifetime  = queriedItem.ConsentLifetime; 			
				result.AbsoluteRefreshTokenLifetime  = queriedItem.AbsoluteRefreshTokenLifetime; 			
				result.SlidingRefreshTokenLifetime  = queriedItem.SlidingRefreshTokenLifetime; 			
				result.RefreshTokenUsage  = queriedItem.RefreshTokenUsage; 			
				result.UpdateAccessTokenClaimsOnRefresh  = queriedItem.UpdateAccessTokenClaimsOnRefresh; 			
				result.RefreshTokenExpiration  = queriedItem.RefreshTokenExpiration; 			
				result.AccessTokenType  = queriedItem.AccessTokenType; 			
				result.EnableLocalLogin  = queriedItem.EnableLocalLogin; 			
				result.IncludeJwtId  = queriedItem.IncludeJwtId; 			
				result.AlwaysSendClientClaims  = queriedItem.AlwaysSendClientClaims; 			
				result.ClientClaimsPrefix  = queriedItem.ClientClaimsPrefix; 			
				result.PairWiseSubjectSalt  = queriedItem.PairWiseSubjectSalt; 			
				result.Created  = queriedItem.Created; 			
				result.Updated  = queriedItem.Updated; 			
				result.LastAccessed  = queriedItem.LastAccessed; 			
				result.UserSsoLifetime  = queriedItem.UserSsoLifetime; 			
				result.UserCodeType  = queriedItem.UserCodeType; 			
				result.DeviceCodeLifetime  = queriedItem.DeviceCodeLifetime; 			
				result.NonEditable  = queriedItem.NonEditable; 

			    return result;				
            }
        }
    }
}


