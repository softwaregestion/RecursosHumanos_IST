using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.API.Models
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

    public class WspMsg
    {
        public string Resultado { get; set; }
    }
   
}
