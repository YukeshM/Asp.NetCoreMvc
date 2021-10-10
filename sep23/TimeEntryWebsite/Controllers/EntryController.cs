using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeEntryWebsite.Data;
using TimeEntryWebsite.ViewModel;

namespace TimeEntryWebsite.Controllers
{
    public class EntryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public EntryController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [Authorize(Roles = "User, Admin")]
        public IActionResult Index()
        {
            IEnumerable<EntryTimeViewModel> entryTimeTableList = _dbContext.EntryTimeTable;
            return View(entryTimeTableList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EntryTimeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.EntryTimeTable.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            IEnumerable<EntryTimeViewModel> entryTimeTableList = _dbContext.EntryTimeTable;
            return View(entryTimeTableList);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
