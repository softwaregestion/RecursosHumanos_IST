// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;


namespace IST.RRHH.Domain.Command.Clients
{   
    

	public class Edit
    {
        public class Command : ICommand
        {		
			
			public  int Id  {get; set;} 			
			public  bool Enabled  {get; set;} 			
			public  string ClientId  {get; set;} 			
			public  string ProtocolType  {get; set;} 			
			public  bool RequireClientSecret  {get; set;} 			
			public  string ClientName  {get; set;} 			
			public  string Description  {get; set;} 			
			public  string ClientUri  {get; set;} 			
			public  string LogoUri  {get; set;} 			
			public  bool RequireConsent  {get; set;} 			
			public  bool AllowRememberConsent  {get; set;} 			
			public  bool AlwaysIncludeUserClaimsInIdToken  {get; set;} 			
			public  bool RequirePkce  {get; set;} 			
			public  bool AllowPlainTextPkce  {get; set;} 			
			public  bool AllowAccessTokensViaBrowser  {get; set;} 			
			public  string FrontChannelLogoutUri  {get; set;} 			
			public  bool FrontChannelLogoutSessionRequired  {get; set;} 			
			public  string BackChannelLogoutUri  {get; set;} 			
			public  bool BackChannelLogoutSessionRequired  {get; set;} 			
			public  bool AllowOfflineAccess  {get; set;} 			
			public  int IdentityTokenLifetime  {get; set;} 			
			public  int AccessTokenLifetime  {get; set;} 			
			public  int AuthorizationCodeLifetime  {get; set;} 			
			public  int? ConsentLifetime  {get; set;} 			
			public  int AbsoluteRefreshTokenLifetime  {get; set;} 			
			public  int SlidingRefreshTokenLifetime  {get; set;} 			
			public  int RefreshTokenUsage  {get; set;} 			
			public  bool UpdateAccessTokenClaimsOnRefresh  {get; set;} 			
			public  int RefreshTokenExpiration  {get; set;} 			
			public  int AccessTokenType  {get; set;} 			
			public  bool EnableLocalLogin  {get; set;} 			
			public  bool IncludeJwtId  {get; set;} 			
			public  bool AlwaysSendClientClaims  {get; set;} 			
			public  string ClientClaimsPrefix  {get; set;} 			
			public  string PairWiseSubjectSalt  {get; set;} 			
			public  DateTime Created  {get; set;} 			
			public  DateTime? Updated  {get; set;} 			
			public  DateTime? LastAccessed  {get; set;} 			
			public  int? UserSsoLifetime  {get; set;} 			
			public  string UserCodeType  {get; set;} 			
			public  int DeviceCodeLifetime  {get; set;} 			
			public  bool NonEditable  {get; set;} 				
        }
 
        public class Handler : ICommandHandler<Command>
        {
            IBDContext context;
 
            public Handler(IBDContext context)
            {
                this.context = context;
            } 
 
            public void Handle(Command command)
            {
				var item = context.Clients.SingleOrDefault(c => 
						 c.Id == command.Id
					);

				if (item == null)
					throw new BusinessException("El ítem a eliminar no existe");

			
				item.Enabled  = command.Enabled; 			
				item.ClientId  = command.ClientId; 			
				item.ProtocolType  = command.ProtocolType; 			
				item.RequireClientSecret  = command.RequireClientSecret; 			
				item.ClientName  = command.ClientName; 			
				item.Description  = command.Description; 			
				item.ClientUri  = command.ClientUri; 			
				item.LogoUri  = command.LogoUri; 			
				item.RequireConsent  = command.RequireConsent; 			
				item.AllowRememberConsent  = command.AllowRememberConsent; 			
				item.AlwaysIncludeUserClaimsInIdToken  = command.AlwaysIncludeUserClaimsInIdToken; 			
				item.RequirePkce  = command.RequirePkce; 			
				item.AllowPlainTextPkce  = command.AllowPlainTextPkce; 			
				item.AllowAccessTokensViaBrowser  = command.AllowAccessTokensViaBrowser; 			
				item.FrontChannelLogoutUri  = command.FrontChannelLogoutUri; 			
				item.FrontChannelLogoutSessionRequired  = command.FrontChannelLogoutSessionRequired; 			
				item.BackChannelLogoutUri  = command.BackChannelLogoutUri; 			
				item.BackChannelLogoutSessionRequired  = command.BackChannelLogoutSessionRequired; 			
				item.AllowOfflineAccess  = command.AllowOfflineAccess; 			
				item.IdentityTokenLifetime  = command.IdentityTokenLifetime; 			
				item.AccessTokenLifetime  = command.AccessTokenLifetime; 			
				item.AuthorizationCodeLifetime  = command.AuthorizationCodeLifetime; 			
				item.ConsentLifetime  = command.ConsentLifetime; 			
				item.AbsoluteRefreshTokenLifetime  = command.AbsoluteRefreshTokenLifetime; 			
				item.SlidingRefreshTokenLifetime  = command.SlidingRefreshTokenLifetime; 			
				item.RefreshTokenUsage  = command.RefreshTokenUsage; 			
				item.UpdateAccessTokenClaimsOnRefresh  = command.UpdateAccessTokenClaimsOnRefresh; 			
				item.RefreshTokenExpiration  = command.RefreshTokenExpiration; 			
				item.AccessTokenType  = command.AccessTokenType; 			
				item.EnableLocalLogin  = command.EnableLocalLogin; 			
				item.IncludeJwtId  = command.IncludeJwtId; 			
				item.AlwaysSendClientClaims  = command.AlwaysSendClientClaims; 			
				item.ClientClaimsPrefix  = command.ClientClaimsPrefix; 			
				item.PairWiseSubjectSalt  = command.PairWiseSubjectSalt; 			
				item.Created  = command.Created; 			
				item.Updated  = command.Updated; 			
				item.LastAccessed  = command.LastAccessed; 			
				item.UserSsoLifetime  = command.UserSsoLifetime; 			
				item.UserCodeType  = command.UserCodeType; 			
				item.DeviceCodeLifetime  = command.DeviceCodeLifetime; 			
				item.NonEditable  = command.NonEditable; 				

				//context.Clients.Add(item);
                
                context.SaveChanges();
               
            }
        }
    }
}


