using System;
using System.IO;
using System.Collections.Generic;
using CoffeeSim.IOModels;

namespace CoffeeSim
{
    public class CoffeeFileManager : BaseFileManager
    {
        private static CoffeeFileManager onlyInstance;

        private CoffeeFileManager() : base("coffees.json")
        {
        }

        public new List<CoffeeModel> ReadData()
        {
            List<BeverageModel> temp = base.ReadData();

            if(temp == null)
            {
                return new List<CoffeeModel>();
            }

            List<CoffeeModel> realList = new List<CoffeeModel>();

            foreach (CoffeeModel current in temp)
            {
                realList.Add(current as CoffeeModel);
            }

            return realList;
        }

        public static CoffeeFileManager GetInstance()
        {
            if(onlyInstance == null)
            {
                onlyInstance = new CoffeeFileManager();
            }

            return onlyInstance;
        }
    }
}
