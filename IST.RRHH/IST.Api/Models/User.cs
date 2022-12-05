using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.Api.Models
{
    public class User
    {
        public Guid sub { get; set; }

        public string preferred_username { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string email_verified { get; set; }
        public List<Claims> Claims { get; internal set; }
    }

   
}
