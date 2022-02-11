using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SMOA.Web.Models;
using static SMOA.Web.Models.IdentityModel;

namespace SMOA.Web.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        public AppUserManager UserManager { get; private set; }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public AccountController()
        {
            this.UserManager = new AppUserManager();
        }

        [AllowAnonymous]
        private async Task SignInAsync(AppUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut();
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (this.LoggedUser == null)
            {
                ViewBag.ReturnUrl = returnUrl;
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
                ViewBag.Error = TempData["error"];
                return View();
            }
            else
            {
                //For future roles conditional routing
                //if (this.LoggedUser.Role == Business.Enums.Role.Administrator)
                //{
                //    //Admin Role
                //}
                //else
                //{ 
                //    //Other Roles...
                //}
                return RedirectToRoute("AdminEnrollmentIndex");
            }

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindAsync(model.Username, model.Password);
                if (user != null)
                {


                    if (user.Roles.RoleId == (int)Business.Enums.Role.Administrator)
                    {
                        await SignInAsync(user, model.RememberMe);
                        return Redirect("/Admin/SMOA/Index");
                    }
                    else
                    {

                        await SignInAsync(user, model.RememberMe);
                        return RedirectToAction("Index", "Enrollment");
                    }
                }
            }

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        [OutputCache(VaryByParam = "*", Duration = 0, NoStore = true)]

        public void TempDataToViewBag()
        {
            if (TempData.ContainsKey("Success"))
            {
                ViewBag.SuccessMessage = TempData["Success"].ToString();
            }
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"].ToString();
            }
            if (TempData.ContainsKey("Error"))
            {
                ViewBag.Error = TempData["Error"].ToString();
            }
        }
    }
}