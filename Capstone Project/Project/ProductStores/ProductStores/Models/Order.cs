using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStores.Models
{
    public class Order
    {
        [Key]
        public int OrderNumber { get; set; }
        public string LoginId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAmount { get; set; }
        public int Active { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public User User { get; set; }
    }

}
