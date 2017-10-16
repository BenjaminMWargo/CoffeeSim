using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSim.IOModels
{
    public abstract class BeverageModel
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }

        public BeverageModel(string name, Decimal price)
        {
            Name = name;
            Price = price;
        }

        public string GetDescription() 
        {
            return this.Name + " - " + this.Price;
        }
    }
}
