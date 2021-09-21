using HotelMenuRepository.DataAccess.Repository;
using HotelMenuRepository.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelMenuProject.Controllers
{
    public class MenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMenuRepository _menuRepository;


        //for unit of work
        public MenuController(IUnitOfWork unitOfWork,
              IMenuRepository menuRepository)
        {
            this._unitOfWork = unitOfWork;
            this._menuRepository = menuRepository;
        }

        //public MenuController(IMenu menu)
        //{
        //    _menu = menu;
        //}


        //for unit of work
        [HttpGet]
        public IActionResult Index()
        {
            var menu = _menuRepository.GetAllMenu();
            //var menu = _unitOfWork.MenuList.GetAllMenu();
            return View(menu);
        }


        //for repo pattern
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var menu = _menu.GetAllMenu();
        //    return View(menu);
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            _menuRepository.Insert(menu);
            _unitOfWork.Save(menu);
            return RedirectToAction("Index", "Menu");
        }

        //[HttpGet]
        //public IActionResult Delete(int Id)
        //{
        //    var menu = _menuRepository.GetById(Id);
        //    return View(menu);
        //}


        [HttpPost]
        public IActionResult Delete(Menu menu)
        {
            _menuRepository.Delete(menu);
            _menuRepository.Save();
            return RedirectToAction("Index", "Menu");
        }

        //[HttpGet]
        //public IActionResult Details(int Id)
        //{
        //    var menu = _menuRepository.GetAllMenu(Id);
        //    return View(menu);
        //}

        [HttpGet]
        public IActionResult Update(int Id)
        {
            var menu = _menuRepository.(Id);
            return View(menu);
        }

        [HttpPost]
        public IActionResult Update(Menu menu)
        {

            _menuRepository.Update(menu);
            _menuRepository.Save();
            return View();
        }
    }
}
