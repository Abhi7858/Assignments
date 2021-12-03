using System.Web.Mvc;
using AtmSystem.Models;

namespace AtmSystem.Controllers
{
    public class CustomersController : Controller
    {
        CustomerContext customerDb = new CustomerContext();
        public ActionResult Index(Customer customer)=> View(customer);
        public ActionResult Withdraw(int id)
        {
            Customer customer=customerDb.CustomerTable.Find(id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Withdraw(Customer updatedCustomer)
        {
            Customer customer = customerDb.CustomerTable.Find(updatedCustomer.Accountno);
            if (customer.Balance >= updatedCustomer.Balance)
            {
                customer.Balance = customer.Balance - updatedCustomer.Balance;
                customerDb.SaveChanges();
                return RedirectToAction("Index",customer);
            }
            else
                return RedirectToAction("Insufficient",customer);   
        }
        public ActionResult Insufficient(Customer customer)=> View(customer);
        public ActionResult Transfer(int? id)
        {
            Customer customer = customerDb.CustomerTable.Find(id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Transfer(Customer updatedCustomer,int? receiverCustomerId)
        {
            Customer senderCustomer = customerDb.CustomerTable.Find(updatedCustomer.Accountno);
            Customer receiverCustomer = customerDb.CustomerTable.Find(receiverCustomerId);
            if (senderCustomer.Balance >= updatedCustomer.Balance)
            {
                if (receiverCustomer != null)
                {
                    receiverCustomer.Balance = receiverCustomer.Balance + updatedCustomer.Balance;
                    senderCustomer.Balance = senderCustomer.Balance - updatedCustomer.Balance;
                    customerDb.SaveChanges();
                }
                else
                    return RedirectToAction("InvalidCustomer",senderCustomer);
                return RedirectToAction("Index",senderCustomer);
            }
            else
                return RedirectToAction("Insufficient", senderCustomer);
        }
        public ActionResult InvalidCustomer(Customer customer)=> View(customer);
    }
}