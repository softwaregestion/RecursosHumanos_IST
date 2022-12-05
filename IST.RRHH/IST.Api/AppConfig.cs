
namespace IST.Api
{
    public static class AppConfig
    {
        
        public static string CustomEntityUrl = Configuracion.Instalador.Contexto.GetBd();

        public static string UrlSSO = Configuracion.Instalador.Contexto.GetSSO();

        public static string UrlWeb = Configuracion.Instalador.Contexto.GetWeb();


        public static string UrlApi = Configuracion.Instalador.Contexto.GetApi();

        public static string ClientId = Configuracion.Instalador.Contexto.GetClienteWeb();

        public static bool RequireHttpsMetadata = false;

        public static int DiasCompromisoBase = 1;
    }
}
