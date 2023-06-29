using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
