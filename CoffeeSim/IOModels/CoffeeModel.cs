using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSim.IOModels
{
    public class CoffeeModel : BeverageModel
    {
        public List<ToppingModel> Toppings { get; set; }

        public CoffeeModel(string name, Decimal price) : base(name, price)
        {
        }
    }
}
