using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DataAccess
{
    public class User
    {
        public static List<DTO.User> returnsUsers()
        {
            var users = new List<DTO.User>();
            users.Add(new DTO.User { Name = "user x", Surname = " Lastname X" });
            users.Add(new DTO.User {Name = "user x1", Surname = " Lastname X1" });
            users.Add(new DTO.User {Name = "user x2", Surname = " Lastname X2" });
            users.Add(new DTO.User {Name = "user x3", Surname = " Lastname X3" });
            users.Add(new DTO.User {Name = "user x4", Surname = " Lastname X4" });
            users.Add(new DTO.User {Name = "user x5", Surname = " Lastname X5" });
            users.Add(new DTO.User {Name = "user x6", Surname = " Lastname X6" });
            users.Add(new DTO.User {Name = "user x7", Surname = " Lastname X7" });
            return users;
        }
    }
}
