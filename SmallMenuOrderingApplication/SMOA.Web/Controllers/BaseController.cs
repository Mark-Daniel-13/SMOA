using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace SMOA.Web.Controllers
{
    public class BaseController : Controller
    {
        public Models.IdentityModel.AppPrincipal User
        {
            get
            {
                try
                {
                    return new Models.IdentityModel.AppPrincipal(base.User);
                }
                catch
                {
                    return null;
                }
            }
        }

        public Business.Models.User LoggedUser
        {
            private set; get;
        }

        protected override void OnAuthentication(System.Web.Mvc.Filters.AuthenticationContext filterContext)
        {
            ClaimsIdentity identity = this.User.Identity as ClaimsIdentity;
            if (this.User != null && this.User.Identity != null && this.User.Identity.IsAuthenticated)
            {
                try
                {
                    int userId = 0;
                    int.TryParse(identity.FindFirst(ClaimTypes.Sid).Value, out userId);
                    this.LoggedUser = Business.Facades.User.GetById(userId);
                }
                catch
                {

                }
            }
        }

        public void RemoveModelState(string key)
        {
            if (ModelState.ContainsKey(key))
                ModelState[key].Errors.Clear();
        }
    }
}