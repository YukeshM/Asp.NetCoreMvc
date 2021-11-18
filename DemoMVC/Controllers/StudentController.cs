using DemoMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{


    public class StudentController : Controller
    {

        StudentDetail _db = new StudentDetail();

        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<Student> studentList = _db.Students.ToList();
            return View(studentList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var studentDetail = _db.Students.Find(id);
            return View(studentDetail);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student studentDetail)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _db.Students.Add(studentDetail);
                    _db.SaveChanges();
                    return View();

                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        // GET: Student/Edit/5
        [HttpGet]
        public JsonResult GetId(int id)
        {
            if (id != 0)
            {

                var studentDetail = _db.Students.Find(id);
                return Json(studentDetail, JsonRequestBehavior.AllowGet);
            }
            return Json("Id should not be null");
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student studentDetail)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var detail = _db.Students.Find(studentDetail.Id);
                    detail.StudentName = studentDetail.StudentName;
                    detail.Age = studentDetail.Age;
                    _db.SaveChanges();
                    return View();
                }

                return View();
            }
            catch
            {
                return View();
            }
        }


        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var detail = _db.Students.Find(id);
                _db.Students.Remove(detail);
                _db.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            catch
            {
                return View();
            }
        }
    }
}
