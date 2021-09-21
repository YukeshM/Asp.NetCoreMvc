using HotelMenuApplicationRepository.DataAccess.Repository;
using HotelMenuApplicationRepository.Models.Models;
using HotelMenuApplicationRepository.Models.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace HotelMenuApplication.Controllers
{
    public class MenuController : Controller
    {

        private readonly IMenuRepository _menuRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MenuController(IMenuRepository menuRepository, 
            IWebHostEnvironment webHostEnvironment)
        {
            this._menuRepository = menuRepository;
            this._webHostEnvironment = webHostEnvironment;
        }
        // GET: MenuController
        public ActionResult Index()
        {
            var menuList = _menuRepository.GetAllMenu();
            return View(menuList);
        }


        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                var menu = new Menu
                {
                    Id = model.Id,
                    DishName = model.DishName,
                    DishDescription = model.DishDescription,
                    VegOrNonVeg = model.VegOrNonVeg,
                    Category = model.Category,
                    Price = model.Price,
                    DishImage = uniqueFileName ,
                };

                _menuRepository.Insert(menu);
                _menuRepository.Save();
                return RedirectToAction("Index");
            }
            return View();

        }

        //for image
        private string UploadedFile(MenuViewModel model)
        {
            string uniqueFileName = null;

            if (model.DishImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.DishImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.DishImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var menu = _menuRepository.GetById(id);
            return View(menu);
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _menuRepository.Update(menu);
                _menuRepository.Save();
                return RedirectToAction("Index");

            }          
            return View();      
        }

        
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuDelete = _menuRepository.GetById(id);

            if (menuDelete == null)
            {
                return NotFound();
            }
            _menuRepository.Delete(id);
            _menuRepository.Save();
            return RedirectToAction("Index");
        }      
    }
}
