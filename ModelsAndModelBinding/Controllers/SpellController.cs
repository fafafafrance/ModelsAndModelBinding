using Microsoft.AspNetCore.Mvc;

namespace ModelsAndModelBinding.Controllers
{
    public class SpellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
