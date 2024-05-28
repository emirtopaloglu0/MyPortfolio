using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.ToDoLists.Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.Messages.Where(x => x.IsRead == false).ToList();
            ViewBag.v6 = context.Experiences.ToList();
            ViewBag.v7 = context.Skills.ToList();

            var values = context.ToDoLists.ToList();

            return View(values);
        }
    }
}
