
//using HotelMenuCustomerRepository.DataAccess.Repository;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace HotelMenuApplication.Controllers
//{
//    public class CustomerMenuController : Controller
//    {
//        private readonly ICustomerMenuRepository _customerMenuRepository;

//        public CustomerMenuController(ICustomerMenuRepository customerMenuRepository)
//        {
//            this._customerMenuRepository = customerMenuRepository;
//        }
//        public IActionResult Index()
//        {
//            var customerMenu = _customerMenuRepository.GetAllMenu();
//            return View(customerMenu);
//        }
//    }
//}
