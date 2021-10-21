using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using TimeEntryWebsite.Data;
using TimeEntryWebsite.Models;

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
      IEnumerable<EntryTimeModel> entryTimeTableList = _dbContext.EntryTimeTable;
      return View(entryTimeTableList);
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(EntryTimeModel model)
    {
      if (ModelState.IsValid)
      {
        string userId = User.Claims.FirstOrDefault(
            c => c.Type == ClaimTypes.NameIdentifier).Value;
        model.UserId = userId;
        _dbContext.EntryTimeTable.Add(model);
        _dbContext.SaveChanges();
        return RedirectToAction("Break", "Entry");
      }

      return View(model);
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public IActionResult Admin()
    {
      IEnumerable<EntryTimeModel> entryTimeTableList = _dbContext.EntryTimeTable;

      //  EntryTotallist data = new Enttkjdf();

      //foreach (var item in entryTimeTableList)
      //{
      //    data.EntryId = item.EntryId

      //    data.breaks = _dbContext.BreakTimeTable.Where(Break => break.entryId == item.entryId).ToList();
      //}

      return View(entryTimeTableList);
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult AccessDenied()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Break()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Break(BreakTimeModel model)
    {
      if (ModelState.IsValid)
      {
        _dbContext.BreakTimeTable.Add(model);
        _dbContext.SaveChanges();
        return RedirectToAction("Index", "Entry");
      }

      return View(model);
    }



    public IActionResult GetBreakList()
    {
      IEnumerable<BreakTimeModel> breakTimeList = _dbContext.BreakTimeTable;
      return View(breakTimeList);
    }
  }
}

