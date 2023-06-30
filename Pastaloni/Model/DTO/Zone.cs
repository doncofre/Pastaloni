using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DTO
{
    public class Zone
    {
        public Guid Id { get; set; }
        public List<Client> Clients { get; set; }
    }
}
