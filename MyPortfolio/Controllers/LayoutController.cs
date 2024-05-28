using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
