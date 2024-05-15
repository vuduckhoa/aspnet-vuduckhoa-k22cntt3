using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using vdklesson04.Models;

namespace vdklesson04.Controllers
{
    public class VdkCustomerScaffdingController : Controller
    {
        private List<VdkCustomer> listCustomer = new List<VdkCustomer>()
                {
                new VdkCustomer()
        {
            CustomerId = 1,
                        FirsName = "Vuduckhoa",
                        LastName = "khoa",
                        Address = "k22cnt3",
                        YearOfBirth = 2004
                    },
                new VdkCustomer()
        {
            CustomerId = 2,
                    FirsName = "vukhoa",
                    LastName = "khoa2",
                    Address = "k22cnt3",
                    YearOfBirth = 2004
                },
                new VdkCustomer()
        {
            CustomerId = 3,
                    FirsName = "duckhoa",
                    LastName = "khoa3",
                    Address = "k22cnt3",
                    YearOfBirth = 2004
                },
                new VdkCustomer()
        {
            CustomerId = 4,
                    FirsName = "khoacute",
                    LastName = "khoa4",
                    Address = "k22cnt3",
                    YearOfBirth = 2004
                },
                };
        // GET: VdkCustomerScaffding
        //listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult VdkCreate() 
        {
            var model =new VdkCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult VdkCreate(VdkCustomer model)
        {
            //listCustomer.Add(model); 
            //return View(model);
            return RedirectToAction("Index");
        }
        public ActionResult vdkEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}