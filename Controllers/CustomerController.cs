using Microsoft.AspNetCore.Mvc;
using PassingData.Models;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Customer = new Customer();
            // ViewData.Model = new Customer();
            var customer = new Customer();
            return View(customer);
        }
    }
}
