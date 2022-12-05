namespace IST.RRHH.Web
{
    public class AppConfig
    {
        public static string ConnectionString = Configuracion.Instalador.Contexto.GetBd();

        public static string ClientId = Configuracion.Instalador.Contexto.GetClienteWeb();
        public static string Secret = Configuracion.Instalador.Contexto.GetSecret();
        public static string CookieName = Configuracion.Instalador.Contexto.GetCookie();

        public static string UrlSSO = Configuracion.Instalador.Contexto.GetSSO() + "/";// "https://localhost:44320/";

        public static string rootSSO = Configuracion.Instalador.Contexto.GetSSO();// "https://localhost:44320/";

        public static string UrlWeb = Configuracion.Instalador.Contexto.GetWeb();//"https://localhost:44322";
        public static string ManagerApi = Configuracion.Instalador.Contexto.GetApi() + "/";//" "https://localhost:44321/";

        public static bool RequireHttpsMetadata = false;

        public static int DiasCompromisoBase = 1;

        public static string Smtp = "enviadores.ist.cl";
        public static string EmailOrigen = "noreply@enviadores.ist.cl";
        public static string PasswordOrigen = "shai0uSha2oovoopiK3ooj0u";
        public static int Port = 25;
        public static bool SSL = false;

    }
}
