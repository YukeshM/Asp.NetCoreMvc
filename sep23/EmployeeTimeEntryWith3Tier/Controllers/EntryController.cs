using BusinessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeTimeEntryWith3Tier.Controllers
{
    public class EntryController : Controller
    {
        private readonly EntryBl _entryBl;
        public EntryController(EntryBl entryBl)
        {
            this._entryBl = entryBl;
        }
        public IActionResult Index()

        {
            IEnumerable<EntryTime> result = _entryBl.GetEntry();
            return View(result);
        }

    

//        [HttpGet]
//        [Authorize(Roles = "User, Admin")]

//        public IActionResult Index()
//        {
//            IEnumerable<EntryTimeModel> entryTimeTableList = _dbContext.EntryTimeTable;
//            return View(entryTimeTableList);
//        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( EntryTime model)
        {
            if (ModelState.IsValid)
            {
                _entryBl.Create( model);
                return RedirectToAction("Index", "Home");
                //string userId = User.Claims.FirstOrDefault(
                //    c => c.Type == ClaimTypes.NameIdentifier).Value;
                //model.UserId = userId;
                //_dbContext.EntryTimeTable.Add(model);
                //_dbContext.SaveChanges();
                //return RedirectToAction("Break", "Entry");
            }

            return View(model);
        }


        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                _entryBl.CreateUser(user);
                return RedirectToAction("Index", "Home");
                
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult CreateBreak()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBreak(BreakTime breakTime)
        {
            if (ModelState.IsValid)
            {
                _entryBl.CreateBreak(breakTime);
                return RedirectToAction("Index", "Home");
            }

            return View(breakTime);
        }


        public IActionResult GetEmployee()
        {
           IEnumerable<EmployeeViewModel> result = _entryBl.GetEmployee();
            return View(result);
        }

        public IActionResult GetAllEmployee()
        {
            IEnumerable<EmployeeViewModel> employeeViewModel = _entryBl.GetAllEmployee();
            return View(employeeViewModel);
        }
        //        [HttpGet]
        //        [Authorize(Roles = "Admin")]
        //        public IActionResult Admin()
        //        {
        //            IEnumerable<EntryTimeModel> entryTimeTableList = _dbContext.EntryTimeTable;

        //            //  EntryTotallist data = new Enttkjdf();

        //            //  foreach (var item in entryTimeTableList)
        //            //  {
        //            //      data.EntryId = item.EntryId

        //            //data.breaks = _dbContext.BreakTimeTable.Where(Break => break.entryId == item.entryId).ToList();
        //            //  }

        //            return View(entryTimeTableList);
        //        }

        //        [HttpGet]
        //        [AllowAnonymous]
        //        public IActionResult AccessDenied()
        //        {
        //            return View();
        //        }

        //        [HttpGet]
        //        public IActionResult Break()
        //        {
        //            return View();
        //        }

        //        [HttpPost]
        //        public IActionResult Break(BreakTimeModel model)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                _dbContext.BreakTimeTable.Add(model);
        //                _dbContext.SaveChanges();
        //                return RedirectToAction("Index", "Entry");
        //            }

        //            return View(model);
        //        }



        //        public IActionResult GetBreakList()
        //        {
        //            IEnumerable<BreakTimeModel> breakTimeList = _dbContext.BreakTimeTable;
        //            return View(breakTimeList);
        //        }
    }
}
