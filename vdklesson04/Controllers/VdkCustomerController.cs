using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using vdklesson04.Models;

namespace vdklesson04.Controllers
{
    public class VdkCustomerController : Controller
    {
        // GET: VdkCustomer
        public ActionResult Index()
        {
            return View();
        }
        // action :VdkCustomerDetail
        public ActionResult VdkCustomerDetail() 
        {
            // tao doi tuong du lieu 
            var customer = new VdkCustomer()
            {
                CustomerId = 1,
                FirsName = "Vuduckhoa",
                LastName = "khoa",
                Address = "k22cnt3",
                YearOfBirth = 2004
            };
            ViewBag.customer= customer;
            return View();
        }
        //get VdkListCustomer
        public ActionResult VdkListCustomer() 
        { 
            var list = new List<VdkCustomer>()
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
                    CustomerId= 2,
                    FirsName="vukhoa",
                    LastName="khoa2",
                    Address="k22cnt3",
                    YearOfBirth=2004
                },
                new VdkCustomer()
                {
                    CustomerId= 3,
                    FirsName="duckhoa",
                    LastName="khoa3",
                    Address="k22cnt3",
                    YearOfBirth=2004
                },
                new VdkCustomer()
                {
                    CustomerId= 4,
                    FirsName="khoacute",
                    LastName="khoa4",
                    Address="k22cnt3",
                    YearOfBirth=2004
                },
                };
            //ViewBag.list= list;// dua du lieu ra bang doi tuong viewbag

        return View(list);
        }
    }
}