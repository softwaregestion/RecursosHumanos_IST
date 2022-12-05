using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Domain.Utilidades
{
    public class LlamarSpHelper
    {
        public static DataTable GetResultProcedureStoreParameterReporteDinamico(string procedure, List<ParameterVariables> Variables, IBDContext context)
        {
            if (Variables == null)
                Variables = new List<ParameterVariables>();

            var dt = new DataTable();
            //var conn = context.Database.Connection;

           SqlConnection conn = new SqlConnection(IST.RRHH.Domain.Startup.ConnectionString);

            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo." + procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var item in Variables)
                    {
                        switch (item.Tipo)
                        {
                            case ParameterVariablesTipo.Varchar:

                                string texto = null;

                                //if (!string.IsNullOrEmpty(item.Value))
                                //{
                                    texto = item.Value;
                                //}

                                cmd.Parameters.Add(new SqlParameter(item.Variable, texto));

                                break;

                            case ParameterVariablesTipo.Int:

                                int? numero = null;
                                int num = 0;
                                if (int.TryParse(item.Value, out num))
                                {
                                    numero = num;
                                }

                                cmd.Parameters.Add(new SqlParameter(item.Variable, numero));

                                break;
                            case ParameterVariablesTipo.Decimal:

                                decimal? dec = null;
                                decimal de = 0;
                                if (decimal.TryParse(item.Value, out de))
                                {
                                    dec = de;
                                }

                                cmd.Parameters.Add(new SqlParameter(item.Variable, dec));

                                break;
                            case ParameterVariablesTipo.DateTime:

                                DateTime? dtfecha = null;

                                DateTime dtfechaD = new DateTime();

                                if (DateTime.TryParse(item.Value, out dtfechaD))
                                {
                                    if (dtfechaD.Date == new DateTime(1, 1, 1).Date)
                                    {
                                        dtfecha = null;
                                    }
                                    else
                                    {
                                        dtfecha = dtfechaD;
                                    }
                                    
                                }

                                cmd.Parameters.Add(new SqlParameter(item.Variable, dtfecha));

                                break;
                        }
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                                        
                    cmd.Dispose();
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                // error handling
                if (connectionState != ConnectionState.Closed) conn.Close();
                return dt;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }
    }
}
