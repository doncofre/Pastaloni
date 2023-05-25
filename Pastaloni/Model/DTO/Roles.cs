using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DTO
{
    public class Roles
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
