using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DTO
{
    public class Voucher
    {
        public Guid guid { get; set; }
        public Guid Id_SalesMan { get; set; }
        public Guid Client { get; set; }
        public decimal Total { get; set; }
        public double Off { get; set; }
        public List<Product> Products { get; set; }

    }
}
