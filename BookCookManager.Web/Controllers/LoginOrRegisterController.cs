using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookCookManager.Web.Controllers
{
    public class LoginOrRegisterController : Controller
    {
        // GET: LoginOrRegister

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // TODO: autent
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string username, string email, string password)
        {
            // TODO: register
            return RedirectToAction("Index", "Home");
        }
    }
}