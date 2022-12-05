using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Model.ProcedureStore
{
    public class CallProcedure
    {
        public class ParameterReporte
        {

            public DateTime Fecha { get; set; }
            public string RegionId { get; set; }
            public string OficinaId { get; set; }
        }

        public class ParameterReporteDetalle
        {


            public string Id { get; set; }
        }

        public DataTable GetResultProcedureStore(string procedure, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "dbo." + procedure;
                    cmd.CommandType = CommandType.StoredProcedure;




                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }

        public DataTable GetResultProcedureStoreRevAtencionXRut(string procedure, DateTime fecha, string rut, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo." + procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("Fecha", fecha));
                    cmd.Parameters.Add(new SqlParameter("RutPer", rut));

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }


        public DataTable GetResultProcedureStoreConsolidado(Guid IdLicitacion, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo.Consolidado";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("IdLicitacion", IdLicitacion));


                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }

        public DataTable GetResultProcedureStoreConsolidadoPropuesta(Guid IdLicitacion, Guid IdLicitacionPropuesta, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo.ConsolidadoPropuesta";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("IdLicitacion", IdLicitacion));
                    cmd.Parameters.Add(new SqlParameter("IdLicitacionPropuesta", IdLicitacionPropuesta));


                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }

        public DataTable GetResultProcedureStoreParameterFolio(string procedure, string folio, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo." + procedure;
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.Add(new SqlParameter("folio", folio));

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }


        public DataTable GetResultProcedureStoreParameterDenuncioXFolio(string procedure, string folio, string tipo, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo." + procedure;
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.Add(new SqlParameter("folio", folio));
                    cmd.Parameters.Add(new SqlParameter("tipo", tipo));

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }


        public DataTable GetResultProcedureStoreParameterReporteDetalle(string procedure, ParameterReporteDetalle parametros, IBDContext context)
        {

            var dt = new DataTable();
            var conn = context.Database.Connection;
            var connectionState = conn.State;
            try
            {
                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 45000;
                    cmd.CommandText = "dbo." + procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("Id", parametros.Id));

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling
                throw;
            }
            finally
            {
                if (connectionState != ConnectionState.Closed) conn.Close();
            }
            return dt;

        }
    }
}
