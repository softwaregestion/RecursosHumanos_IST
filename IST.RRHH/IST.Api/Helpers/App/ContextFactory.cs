using Emsesa.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace Emsesa.Api.Helpers.App
{
    

    public class ContextExtendedFactory : IDbContextFactory<ContextExtended>
    {
        public ContextExtended Create()
        {
            return new ContextExtended(AppConfig.CustomEntityUrl);
        }
    }
}
