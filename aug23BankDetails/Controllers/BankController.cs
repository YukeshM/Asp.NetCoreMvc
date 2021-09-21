using aug23BankDetails.Data;
using aug23BankDetails.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aug23BankDetails.Controllers
{
    public class BankController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BankController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BankDetails> bankDetails = _db.UserDetails;
            return View(bankDetails);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BankDetails bankDetailsObject)
        {
            if (ModelState.IsValid)
            {
                _db.UserDetails.Add(bankDetailsObject);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(bankDetailsObject);
        }
    }
}
