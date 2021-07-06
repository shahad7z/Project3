using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test.Net.Models;
using test.Net.Repository;

namespace test.Net.Controllers
{
    public class HomeController : Controller
    {
       

      private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public int customerID { get; private set; }

       public HomeController(ILogger<HomeController> logger , AppDbContext context )
        {
            _logger = logger;
            _context = context;
            
        }

        public ActionResult Index() {
            
           return View(_context.products.ToList());
          }


        public ActionResult Details(int id )
        {
            var result = _context.products.Where(c => c.productId == id).FirstOrDefault();
            return View(result);
        }



        public IActionResult Registration()
        {
           
            return View();
        }

        public IActionResult Registrationinfo(customer model)
        {
            customer Newcustomer = new customer();

            Newcustomer.customerID = model.customerID;
            Newcustomer.Name = model.Name;
            Newcustomer.Email = model.Email;
            Newcustomer.Address = model.Address;
            Newcustomer.UserName = model.UserName;
            Newcustomer.password = model.password;

            _context.customers.Add(Newcustomer);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }


          public IActionResult MakeOrder(int id)
        {
            var result = _context.products.Where(c => c.productId == id).FirstOrDefault();
          
            return View(result);
        }

        public IActionResult SaveOrder(product model)
        {
            order Neworder = new order();

            Neworder.orderID = model.Order.orderID;

            Neworder.productId = model.productId;
            Neworder.NumperOfItem = model.Order.NumperOfItem;
            Neworder.orderPrice = Convert.ToInt32(model.price);
            Neworder.orderDate = DateTime.Now;
            Neworder.customerID = 6;

            _context.orders.Add(Neworder);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
