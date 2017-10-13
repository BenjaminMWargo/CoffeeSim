using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSim.IOModels
{
    public class ToppingModel : BeverageModel
    {
        public ToppingModel(string name, Decimal price) : base(name, price)
        {
        }
    }
}
