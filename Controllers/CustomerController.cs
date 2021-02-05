using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            var customers = GetCustomers();   
            return View(customers);
        }

        [Route("Customer/Details/{id}")]
        public ActionResult Details(int id)
        {

            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            else
            {
                return View(customer);
            }

            
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
                {
                new Customer  {Id=1, Name="John Bin"},
                new Customer  {Id=2, Name="Danziel Wasington"}
                };
        }

        

    }
}