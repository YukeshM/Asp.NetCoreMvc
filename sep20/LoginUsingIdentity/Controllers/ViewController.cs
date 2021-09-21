using LoginUsingIdentity.Data;
using LoginUsingIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LoginUsingIdentity.Controllers
{
    public class ViewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Feedback> result = _context.FeedbackTable;
            return View(result);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feedback model)
        {
            if (ModelState.IsValid)
            {
                _context.FeedbackTable.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View("Index", "Home");
        }
    }
}
