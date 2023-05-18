using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Controllers
{
    public class WhatsappController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
