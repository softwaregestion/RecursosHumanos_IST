using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Models
{
	public class ClaimsModel
	{
		public int Id { get; set; }
		public string ClaimType { get; set; }
		public string ClaimValue { get; set; }
		public string UserId { get; set; }

	}
}
