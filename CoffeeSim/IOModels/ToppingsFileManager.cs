using System;
using System.Collections.Generic;
namespace CoffeeSim.IOModels
{
    public class ToppingsFileManager : BaseFileManager
    {
        private static ToppingsFileManager onlyInstance;

        public ToppingsFileManager() : base("toppings.json")
        {
        }

        public new List<ToppingModel> ReadData()
        {
            List<BeverageModel> temp = base.ReadData();

            if (temp == null)
            {
                return new List<ToppingModel>();
            }

            List<ToppingModel> realList = new List<ToppingModel>();

            foreach (ToppingModel current in temp)
            {
                realList.Add(current as ToppingModel);
            }

            return realList;
        }

        public static ToppingsFileManager GetInstance()
        {
            if (onlyInstance == null)
            {
                onlyInstance = new ToppingsFileManager();
            }

            return onlyInstance;
        }
    }
}
