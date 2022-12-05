// **********************************
// **********************************
// **********************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
namespace IST.RRHH.Domain.Command.AspNetUsers
{   
    

	public class Create
    {
        public class Command : ICommand
        {

			
			//Soy PK  
			public  string Id  {get; set;}  
			public  int AccessFailedCount  {get; set;}  
			public  string ConcurrencyStamp  {get; set;}  
			public  string Email  {get; set;}  
			public  bool EmailConfirmed  {get; set;}  
			public  bool LockoutEnabled  {get; set;}  
			public  DateTimeOffset? LockoutEnd  {get; set;}  
			public  string NormalizedEmail  {get; set;}  
			public  string NormalizedUserName  {get; set;}  
			public  string PasswordHash  {get; set;}  
			public  string PhoneNumber  {get; set;}  
			public  bool PhoneNumberConfirmed  {get; set;}  
			public  string SecurityStamp  {get; set;}  
			public  bool TwoFactorEnabled  {get; set;}  
			public  string UserName  {get; set;} 			
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

				var item = new Model.AspNetUsers();

			
				//Soy PK  
				item.Id  = command.Id;  
				item.AccessFailedCount  = command.AccessFailedCount;  
				item.ConcurrencyStamp  = command.ConcurrencyStamp;  
				item.Email  = command.Email;  
				item.EmailConfirmed  = command.EmailConfirmed;  
				item.LockoutEnabled  = command.LockoutEnabled;  
				item.LockoutEnd  = command.LockoutEnd;  
				item.NormalizedEmail  = command.NormalizedEmail;  
				item.NormalizedUserName  = command.NormalizedUserName;  
				item.PasswordHash  = command.PasswordHash;  
				item.PhoneNumber  = command.PhoneNumber;  
				item.PhoneNumberConfirmed  = command.PhoneNumberConfirmed;  
				item.SecurityStamp  = command.SecurityStamp;  
				item.TwoFactorEnabled  = command.TwoFactorEnabled;  
				item.UserName  = command.UserName; 				

				context.AspNetUsers.Add(item);
                
                context.SaveChanges();
			
			
				
            }
        }
    }
}


