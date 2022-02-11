using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.Business.Facades
{
    public class UserRole
    {
        public static Models.UserRole ToModel(Data.userrole role)
        {
            return new Models.UserRole()
            {
                UserRoleId = role.UserRoleId,
                RoleId = role.RoleId,
                UserId = role.UserId,
            };
        }

        public static Models.UserRole GetRole(int userId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUserRole = db.FirstOrDefault<Data.userrole>("WHERE UserId = @0 AND EndDate IS NULL", userId);
                if (dbUserRole == null) { return null; }

                return ToModel(dbUserRole);
            }
        }

    }
}
