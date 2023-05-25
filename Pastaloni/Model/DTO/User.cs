using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DTO
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Roles> Roles { get; set; }
        public string Address { get; set; }
    }
    public class Trader : User 
    { 
        public List<string> Ubications { get; set; }
        public List<Zone> Zones { get; set; }

    }
    public class Client : User
    {
       
    }
    public class Administrator : User
    {

    }
    public class WareHouseMan
    {

    }
}
