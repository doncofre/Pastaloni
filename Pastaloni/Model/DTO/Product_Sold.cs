using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DTO
{
    public class Product_Sold : Product
    {
        public Guid VoucherId { get; set; }
    }
}
