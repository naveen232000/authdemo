using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using WebAppFilter.Models;

namespace WebAppFilter.Controllers
{
    //Tea Break Till 12:10
    public class SignInController : Controller
    {
        // GET: SignIn
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SignIn sign)
        {
            if (ModelState.IsValid)
            {
                if ((sign.UserName == "sam1256") && (sign.Password == "sam@1256@1256"))
                {

                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(sign);

                }
            }
            else
            { return View(sign); }

        }
    }
}
