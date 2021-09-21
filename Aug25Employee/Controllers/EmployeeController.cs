using Aug25Employee.Data;
using Aug25Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aug25Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmployeeDetails> employeeDetails = _db.EmployeeDetails;
            return View(employeeDetails);
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> departmentsList = _db.Departments.Select(
                x => new SelectListItem
                {
                    Text = x.Id.ToString(),
                    Value = x.DepartmentName.ToString()
                });

            ViewBag.DepartmentIdDropdown = departmentsList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDetails employeeDetails)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeeDetails.Add(employeeDetails);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(employeeDetails);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var details = _db.EmployeeDetails.FirstOrDefault(x => x.Id == id);
            if (details == null)
            {
                return NotFound();
            }
            return View(details);
        }

        [HttpPost]
        public IActionResult Update(EmployeeDetails employeeDetails)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeeDetails.Update(employeeDetails);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeDetails);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delDetails = _db.EmployeeDetails.Find(id);

            if(delDetails == null)
            {
                return NotFound();
            }
            _db.EmployeeDetails.Remove(delDetails);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
