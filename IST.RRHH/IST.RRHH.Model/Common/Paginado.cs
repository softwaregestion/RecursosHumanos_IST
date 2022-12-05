using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Model.Common
{
    public static class DataExtensions
    {
        public static List<T> GetPageItems<T>(this IQueryable<T> items, Paginado queryRequest)
        {
            var data = items.ToList().GetRange(((queryRequest.Pagina - 1) * queryRequest.TotalPorPagina), queryRequest.TotalPorPagina);
            return data;
        }
    }

    public class Paginado
    {
        public int Pagina { get; set; }

        public int TotalPorPagina { get; set; }

        public Paginado()
        {
            Pagina = 1;
            TotalPorPagina = 15;
        }
    }
}
