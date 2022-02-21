using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStores.Models
{
    public class Product
    {
        [Key]
        public int ProductCode { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Remarks { get; set; }
    }
}
