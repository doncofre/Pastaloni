using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Controller.Controllers
{
    public class PersonaController
    {
        public static List<Model.DTO.User> returnsUserCtrl()
        {
            return Model.DataAccess.User.returnsUsers();
        }
    }
}
