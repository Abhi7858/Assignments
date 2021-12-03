using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AtmSystem.Models;

namespace AtmSystem.Controllers
{
    public class AdminsController : Controller
    {
        public CustomerContext db = new CustomerContext();
        public ActionResult Index()=> View(db.CustomerTable.ToList());       
        public ActionResult Details(int? id)
        {
            if (id == null)
            return  new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Customer Account number is required");    
           Customer customer= db.CustomerTable.Find(id);
            if (customer == null)
            {
                new HttpStatusCodeResult(HttpStatusCode.NotFound, "Customer not found");
            }
            return View(customer);
        }
        public ActionResult Create() => View();
        [HttpPost]
        public ActionResult Create(FormCollection FrmCollection)
        {
            Customer customer = new Customer();
            customer.Name = FrmCollection["Name"];
            customer.Password = FrmCollection["Password"];
            customer.Balance = Convert.ToDecimal(FrmCollection["Balance"]);
            db.CustomerTable.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddBalance(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Customer Account number is required");
            Customer customer = db.CustomerTable.Find(id);
            if (customer == null)
            {
                new HttpStatusCodeResult(HttpStatusCode.NotFound, "Customer not found");
            }
            return View(customer);
        }
        [HttpPost]
        public ActionResult AddBalance(Customer upadatedCustomer)
        {
            Customer customer = db.CustomerTable.Find(upadatedCustomer.Accountno);
            customer.Balance = customer.Balance + upadatedCustomer.Balance;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            Customer customer = db.CustomerTable.Find(id);
             return View(customer);
        }
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            Customer removeCustomer = db.CustomerTable.Find(customer.Accountno);
            if (removeCustomer.Balance == 0)
            {
                db.CustomerTable.Remove(removeCustomer);
                db.SaveChanges();
            }
            else
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Account Balance is not Zero so cannot delete Account");
            return RedirectToAction("Index");
        }



    }
}
        
