using aug27.Business;
using aug27.Data;
using aug27.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aug27.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(
            string sortOrder,
            string searchText,
            int? pageNumber)
        {
            ViewData["NameSortParam"] = sortOrder == "Name" ? "Name_desc" : "Name_asc";
            ViewData["DesignationSortParam"] = sortOrder == "Designation" ? "Designation_desc" : "Designation_asc";
            ViewData["DateSortParam"] = sortOrder == "HireDate" ? "HireDate_desc" : "HireDate_asc";
            ViewData["CurrentSearch"] = searchText;

            var empList = from EmployeeDetails in _db.EmployeeDetails select EmployeeDetails;

            if (!string.IsNullOrEmpty(searchText))
            {
                empList = empList.Where(x => x.Name.ToLower().
                Contains(searchText.ToLower()));
            }

            switch (sortOrder)
            {
                case "Name_asc":
                    empList = empList.OrderBy(x => x.Name);
                    break;
                case "Name_desc":
                    empList = empList.OrderByDescending(x => x.Name);
                    break;
                case "Designation_asc":
                    empList = empList.OrderBy(x => x.Designation);
                    break;
                case "Designation_desc":
                    empList = empList.OrderByDescending(x => x.Designation);
                    break;
                case "Hire_asc":
                    empList = empList.OrderBy(x => x.HireDate);
                    break;
                case "Hire_desc":
                    empList = empList.OrderByDescending(x => x.HireDate);
                    break;
                default:
                    empList = empList.OrderBy(x => x.Id);
                    break;
            }

            int pageSize = 5;
            return View(Pagination<EmployeeDetail>.Display(empList, pageNumber ?? 1, pageSize));

            //IEnumerable<EmployeeDetail> employeeDetails = _db.EmployeeDetails;
            //return View(employeeDetails);
        }
        public IActionResult Create()
        {
            //to get the department id from db
            IEnumerable<SelectListItem> myCategories = _db.Departments.Select(
                x => new SelectListItem
                {
                    Text = x.DepartmentName,
                    Value = x.Id.ToString()
                });

            ViewBag.myDropdown = myCategories;

            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDetail employeeDetails)
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
        public IActionResult Update(EmployeeDetail employeeDetails)
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

            if (delDetails == null)
            {
                return NotFound();
            }
            _db.EmployeeDetails.Remove(delDetails);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
