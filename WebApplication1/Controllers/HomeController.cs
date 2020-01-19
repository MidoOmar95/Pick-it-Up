using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Your register page.";

            return View();
        }
        public ActionResult ProfilePage()
        {
                ViewBag.Message = "Your profile page.";

                return View();
            
        }

        public ActionResult Shops()
        {
            ViewBag.Message = "Your supermarket page.";

            return View();
        }
        public ActionResult Cart()
        {
            ViewBag.Message = "Your cart page.";

            return View();
        }
        public ActionResult Error()
        {
            ViewBag.Message = "Your Error page.";

            return View();
        }
        public ActionResult Checkout()
        {
            ViewBag.Message = "Your Error page.";

            return View();
        }
        public ActionResult SavedOrders()
        {
            ViewBag.Message = "Your Error page.";

            return View();
        }
        public ActionResult EditProfile()
        {
            ViewBag.Message = "Your EditProfile page.";

            return View();
        }
        public ActionResult Orders()
        {
            ViewBag.Message = "Your Orders page.";

            return View();
        }
        public ActionResult Locations()
        {
            ViewBag.Message = "Your Locations page.";

            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.Message = "Your Locations page.";

            return View();
        }
        public ActionResult Shoppage()
        {
            ViewBag.Message = "Your Locations page.";

            return View();
        }

        public ActionResult ChangePassword()
        {
            ViewBag.Message = "Your page tochange a password.";

            return View();
        }

        public ActionResult Favorites()
        {
            ViewBag.Message = "Your page tochange a password.";

            return View();
        }
        

        public ActionResult ShopProducts()
        {
            ViewBag.Message = "Your page tochange a password.";

            return View();
        }

    }
}