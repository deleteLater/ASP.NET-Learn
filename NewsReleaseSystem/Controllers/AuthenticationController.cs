using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsReleaseSystem.Models;
using NewsReleaseSystem.BLL;
using NewsReleaseSystem.BLL.Authentication;

namespace NewsReleaseSystem.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignInValidation(User user)
        {
            if (!Authenticator.CheckUserExists(user))
            {
                JsHelper.Alert("用户名或者密码错误,请重试!");
                return View();
            }
            return Redirect("~/Home/Index");
        }

        [HttpPost]
        public void SignUpHandler(User user)
        {
            string msg = "";
            if (!ModelState.IsValid)
            {
                msg = "数据验证失败, 请重试!";
                JsHelper.AlertAndRedirect(msg, "SignUp");
            }
            else
            {
                msg = "数据验证通过";
                //_context.Users.Add(user);
                //_context.SaveChanges();
            }
            return;
        }
    }
}