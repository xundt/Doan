using Microsoft.AspNetCore.Mvc;

namespace ForKids.Controllers
{
    public class TbMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
