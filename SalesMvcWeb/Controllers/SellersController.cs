using Microsoft.AspNetCore.Mvc;

namespace SalesMvcWeb.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
