//using aug27.Data;
//using aug27.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace aug27.Controllers
//{
//    public class SkillController : Controller
//    {
//        private readonly ApplicationDbContext _db;
//        public SkillController(ApplicationDbContext db)
//        {
//            _db = db;
//        }
//        public IActionResult Index()
//        {
//            IEnumerable<Skills> departments = _db.Skills;
//            return View(departments);
//        }
//        public IActionResult Create()
//        {
//            //to get the department id from db
//            IEnumerable<SelectListItem> mySkills = _db.Skills.Select(
//                x => new SelectListItem
//                {
//                    Text = x.SkillName,
//                    Value = x.SkillId.ToString()
//                });

//            ViewBag.myDropdown = mySkills;

//            return View();
//        }

//        [HttpPost]
//        public IActionResult Create(Skills skill)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Skills.Add(skill);
//                _db.SaveChanges();

//                return RedirectToAction("Index");
//            }
//            return View(skill);
//        }

//        public IActionResult Update(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//            var details = _db.Skills.FirstOrDefault(x => x.SkillId == id);
//            if (details == null)
//            {
//                return NotFound();
//            }
//            return View(details);
//        }

//        [HttpPost]
//        public IActionResult Update(Skills skill)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Skills.Update(skill);
//                _db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(skill);
//        }

//        public IActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var delDetails = _db.Skills.Find(id);

//            if (delDetails == null)
//            {
//                return NotFound();
//            }
//            _db.Skills.Remove(delDetails);
//            _db.SaveChanges();

//            return RedirectToAction("Index");

//        }
//    }
//}
