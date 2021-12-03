using System.Linq;
using System.Web.Mvc;
using AtmSystem.Models;

namespace AtmSystem.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index1()=> View();
        public ActionResult Index()=> View();
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            using(var AdminDetails = new AdminContext())
            {
                bool isValid = AdminDetails.AdminTable.Any(x => x.Username == admin.Username && x.Password == admin.Password);
                if (isValid)
                    return RedirectToAction("Index","Admins");
                else
                    return RedirectToAction("Index1", "Login");
            }
            
        }
        public ActionResult CustomerLogin()=> View();
        [HttpPost]
        public ActionResult CustomerLogin( Customer customer)
        {
            CustomerContext CustomerDetails = new CustomerContext();
            try
            {
                Customer validCustomer = CustomerDetails.CustomerTable.Single(x => x.Name == customer.Name && x.Password == customer.Password);
                    return RedirectToAction("Index", "Customers",validCustomer);
            }
            catch
            {
                return RedirectToAction("Index1", "Login");
            }
            
        }


    }
}