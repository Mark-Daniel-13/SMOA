using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMOA.Business.Facades
{
    public class User
    {
        public static Models.User ToModel(Data.user user, Data.userrole userRole)
        {       
            return new Models.User()
            {
                UserId = user.UserId,
                Username = user.Username,
                Password = user.Password,
                Firstname = user.FirstName,
                Lastname = user.LastName,
                CreationDate = user.CreationDate,
                ModificationDate = user.ModificationDate,
                EndDate = user.EndDate,
                Role = (Enums.Role)userRole.RoleId
            };
        }

        public static Models.User GetByUsername(string username)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUser = db.FirstOrDefault<Data.user>("WHERE Username = @0 AND EndDate IS NULL", username);
                if (dbUser == null) return null;

                var dbUserRoles = db.FirstOrDefault<Data.userrole>("WHERE UserId = @0", dbUser.UserId);

                return ToModel(dbUser, dbUserRoles);
            }
        }
        public static Models.User GetByUsernamePassword(string username, string password)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                //convert password to encrypted md5
                var _password = Helpers.Encryption.EncryptMD5(password);
                var dbUser = db.FirstOrDefault<Data.user>("WHERE Username = @0 AND Password = @1 AND EndDate IS NULL", username, _password);
                if (dbUser == null) return null;

                var dbUserRole = db.FirstOrDefault<Data.userrole>("WHERE UserId = @0", dbUser.UserId);

                return ToModel(dbUser, dbUserRole);
            }
        }
        public static Models.User GetById(int userId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUser = db.FirstOrDefault<Data.user>("WHERE UserId = @0 AND EndDate IS NULL", userId);
                if (dbUser == null) return null;

                var dbUserRoles = db.FirstOrDefault<Data.userrole>("WHERE UserId = @0", dbUser.UserId);

                return ToModel(dbUser, dbUserRoles);
            }
        }
    }
}
