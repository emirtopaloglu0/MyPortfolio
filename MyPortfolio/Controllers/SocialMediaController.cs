using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateMedia()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateMedia(int id) 
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult UpdateMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
