using ImageUpload.Context;
using ImageUpload.Entity;
using ImageUpload.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ImageUpload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ImageUploadContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;
        public HomeController(ILogger<HomeController> logger, ImageUploadContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            this._context = context;
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var files = _context.UploadImages.ToList();
            return View(files);
        }

        [HttpGet]
        public IActionResult ImageUpload()
        {
            return View();
        }


        [HttpPost]
        //use (IFormFile file) for sending multiple files
        public IActionResult ImageUpload(UploadImageModel file)
        {
            var fileName = Upload(file);
            var image = new UploadImage
            {
                Image = fileName.ImageName,
                ImageName = fileName.ImageName,
                ImagePath = fileName.ImagePath
            };
            _context.UploadImages.Add(image);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public UploadImage Upload(UploadImageModel model)
        {
            var imageDetails = new UploadImage();
            if (model.Image != null)
            {
                var uploadDirectory = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                imageDetails.ImageName = DateTime.Now.Ticks.ToString() + model.Image.FileName;
                imageDetails.ImagePath = Path.Combine(uploadDirectory, imageDetails.ImageName);
                using (var stream = new FileStream(imageDetails.ImagePath, FileMode.Create))
                {
                    model.Image.CopyTo(stream);
                }
            }
            return imageDetails;

        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
