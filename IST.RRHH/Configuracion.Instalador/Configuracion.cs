using System;

namespace Configuracion.Instalador
{
    public class Contexto
    {
        public static Entorno QueEjecutar = Entorno.Produccion;

        public enum Entorno
        {
            Produccion,
            QA,
            Localhost
        }

        public static string GetApi()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "https://adherentes.ist.cl/rrhhapi/web";

                case Entorno.QA:
                    return "https://adherentes.ist.cl/rrhhapi/web";

                case Entorno.Localhost:
                    return "https://localhost:44321";

                default:
                    throw new Exception("Error");
            }
        }

        public static string GetSSO()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "https://adherentes.ist.cl/acceso/web";

                case Entorno.QA:
                    return "https://adherentes.ist.cl/acceso/web";

                case Entorno.Localhost:
                    return "https://adherentes.ist.cl/acceso/web";

                default:
                    throw new Exception("Error");
            }
        }

        public static string GetHostRoot()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "https://adherentes.ist.cl";

                case Entorno.QA:
                    return "https://adherentes.ist.cl";

                case Entorno.Localhost:
                    return "https://localhost:44320";

                default:
                    throw new Exception("Error");
            }
        }

        public static string GetWeb()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "https://adherentes.ist.cl/rrhh/web";

                case Entorno.QA:
                    return "https://adherentes.ist.cl/rrhh/web";

                case Entorno.Localhost:
                    return "https://localhost:44322";

                default:
                    throw new Exception("Error");
            }
        }

        public static string GetWebRecovery()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "https://adherentes.ist.cl/acceso/web";

                case Entorno.QA:
                    return "https://adherentes.ist.cl/acceso/web";

                case Entorno.Localhost:
                    return "https://localhost:44322";

                default:
                    throw new Exception("Error");
            }
        }

        public static string GetSecret()
        {
            return "Lmil2JopJBz-GH5tDioogcog";
        }

        public static string GetCookie()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "xxrxrhh.prodx.02022";

                case Entorno.QA:
                    return "xx2rrhh.qax.02022";

                case Entorno.Localhost:
                    return "xxr2rhh.devx.02022";

                default:
                    throw new Exception("Error");
            }
        }
        public static string GetBd()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "Server=170.110.40.47;initial catalog=ACCESO;user id=USR_ACCESO_OWNER;password=7rZ$pwDE;";

                case Entorno.QA:
                    return "Server=170.110.40.47;initial catalog=ACCESO;user id=USR_ACCESO_OWNER;password=7rZ$pwDE;";

                case Entorno.Localhost:
                    return "Server=170.110.40.47;initial catalog=ACCESO;user id=USR_ACCESO_OWNER;password=7rZ$pwDE;";

                default:
                    throw new Exception("Error");
            }
        }

        public static string GetDeveloper()
        {
            return "https://localhost:44322";
        }

        public static string GetEntorno()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "Produccion";

                case Entorno.QA:
                    return "QA";

                case Entorno.Localhost:
                    return "Dev";

                default:
                    throw new Exception("Error");
            }
        }


        public static string GetClienteWeb()
        {
            switch (QueEjecutar)
            {
                case Entorno.Produccion:
                    return "RRHH";

                case Entorno.QA:
                    return "RRHH";

                case Entorno.Localhost:
                    return "externo5";

                default:
                    throw new Exception("Error");
            }
        }
    }
}
