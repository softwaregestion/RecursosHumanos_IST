using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Domain.Utilidades
{
    public interface IServicio
    {
        T CallGetService<T>(string servicio, bool refreshToken = false);
        T CallGetServiceParameter<T>(object json, string servicio, bool refreshToken = false);

        T CallPostService<T, Y>(Y json, string servicio, bool refresToken = false);

    }
}
