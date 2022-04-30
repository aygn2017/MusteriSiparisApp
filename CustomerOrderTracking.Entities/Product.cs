using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderTracking.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }=new List<CustomerOrder>();

    }
}
