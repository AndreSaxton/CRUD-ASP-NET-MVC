using ASP_NET_MVC_CRUD.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page2()
        {
            var vm = new Page2Model();
            vm.FirstName = "Default Name";
            //vm.LastName = ;
            //vm.Age = ;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Page2(Page2Model vm)
        {
            ViewBag.Result = String.Format("{0} {1}; Age {2}", vm.FirstName, vm.LastName, vm.Age);

            return View();
        }
    }
}