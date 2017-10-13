using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSim.IOModels
{
    public class OrderModel
    {
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public Decimal Price { get; set; }
        public CoffeeModel Coffee { get; set; }
    }

    public class OrderFileModel
    {
        public List<OrderModel> Orders { get; set; }
    }
}
