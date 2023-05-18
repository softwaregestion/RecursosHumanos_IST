using System.Collections.Generic;

namespace IST.RRHH.Web.Whatsapp
{
    public class TemplateLoader
    {
        public static List<body> read()
        {
            List<body> templates = new List<body>();
            templates = ContractSerialization.LoadData<List<body>>("templates.xml");
            return templates;
        }
    }
}
