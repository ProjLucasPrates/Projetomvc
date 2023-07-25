using Microsoft.AspNetCore.Mvc;

namespace Projetomvc.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
