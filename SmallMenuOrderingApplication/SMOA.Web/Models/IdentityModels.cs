using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;

namespace SMOA.Web.Models
{
    public class IdentityModel
    {
        public class AppUser : IUser<int>
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public Business.Models.User User { get; set; }
            public AppRole Roles { get; set; }
            public AppUser()
            {
                this.User = new Business.Models.User();
                Roles = new AppRole();
            }
        }

        public class AppRole : IRole
        {
            public int RoleId
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public Business.Enums.Role Role
            {
                get;
                set;
            }

            public string Id => throw new NotImplementedException();
        }

        public class AppUserStore : IUserStore<AppUser, int>
        {
            public Task CreateAsync(AppUser user)
            {
                throw new System.NotImplementedException();
            }

            public Task DeleteAsync(AppUser user)
            {
                throw new System.NotImplementedException();
            }

            public Task<AppUser> FindByIdAsync(int userId)
            {
                throw new System.NotImplementedException();
            }

            public Task<AppUser> FindByNameAsync(string userName)
            {
                throw new System.NotImplementedException();
            }

            public Task UpdateAsync(AppUser user)
            {
                throw new System.NotImplementedException();
            }

            public void Dispose()
            {
                // throw new System.NotImplementedException();
            }
        }

        public class AppUserManager : UserManager<AppUser, int>
        {
            public AppUserManager()
                : base(new AppUserStore())
            {


            }
            public static AppUserManager Create(Microsoft.AspNet.Identity.Owin.IdentityFactoryOptions<AppUserManager> options, Microsoft.Owin.IOwinContext context)
            {
                return new AppUserManager();

            }
            public Task<AppUser> FindAsync(string username, string password)
            {
                var userMan = this;
                Task<AppUser> taskInvoke = Task<AppUser>.Factory.StartNew(() =>
                {
                    var user = Business.Facades.User.GetByUsernamePassword(username, password);
                    if (user == null)
                    {
                        return null;
                    }

                    return new AppUser()
                    {
                        Id = user.UserId,
                        Roles = new AppRole() { RoleId = (int)user.Role, Name = user.Role.ToString() },
                        UserName = user.Username,
                        User = user
                    };
                });
                return taskInvoke;
            }
            public Task<AppUser> FindByNameAsync(string username)
            {
                var userMan = this;
                Task<AppUser> taskInvoke = Task<AppUser>.Factory.StartNew(() =>
                {
                    var user = Business.Facades.User.GetByUsername(username);
                    if (user == null)
                    {
                        return null;
                    }

                    return new AppUser()
                    {
                        Id = user.UserId,
                        Roles = new AppRole() { RoleId = (int)user.Role, Name = user.Role.ToString() },
                        UserName = user.Username,
                        User = user
                    };
                });
                return taskInvoke;
            }

            public override Task<ClaimsIdentity> CreateIdentityAsync(AppUser user, string authenticationType)
            {
                Task<ClaimsIdentity> taskInvoke = Task<ClaimsIdentity>.Factory.StartNew(() =>
                {
                    IList<Claim> claimCollection = new List<Claim>
                    {
                        new Claim(ClaimTypes.Sid, user.Id.ToString()  )
                        , new Claim(ClaimTypes.NameIdentifier, user.UserName  )
                        , new Claim(ClaimTypes.Role, user.Roles.Name )
                    };

                    return new ClaimsIdentity(claimCollection, authenticationType);
                });
                return taskInvoke;
            }
        }

        public class AppPrincipal : IPrincipal
        {
            public AppPrincipal()
            {

            }
            public AppPrincipal(IPrincipal user)
            {
                this.Identity = user.Identity;
            }
            public IIdentity Identity
            {
                get;
            }

            public bool IsInRole(string role)
            {
                var userRoles = ((ClaimsIdentity)HttpContext.Current.User.Identity).Claims.Where(x => x.Type == ClaimTypes.Role).Select(c => c.Value);
                return userRoles.Any(r => r.ToLower().Equals(role.ToLower()));
            }

            public bool IsInRole(Business.Enums.Role role)
            {
                return IsInRole(role.ToString());
            }
        }
    }
}