using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }

        public Order(string customerName, decimal totalPrice)
        {
            if (totalPrice <= 0) throw new Exception("Giá trị đơn hàng phải lớn hơn 0.");
            CustomerName = customerName;
            TotalPrice = totalPrice;
        }
    }
}
