using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeSim.IOModels;
using Newtonsoft;
using Newtonsoft.Json;

namespace CoffeeSim
{
    public class OrderHistoryFileManager
    {
        private static OrderHistoryFileManager orderHistory;
        private string OrderFilePath;

        private OrderHistoryFileManager()
        {
            OrderFilePath = "OrderHistory.json";

            //touch a file here?
            if (!File.Exists(OrderFilePath))
            {
                File.Create(OrderFilePath); //this doesn't actually do anything...
            }
        }

        public static OrderHistoryFileManager GetInstance()
        {
            if (orderHistory == null)
            {
                orderHistory = new OrderHistoryFileManager();
            }

            return orderHistory;
        }


        private void WriteFile(List<OrderModel> orderFile)
        {
            string fileContents = JsonConvert.SerializeObject(orderFile);
            using (StreamWriter sw = new StreamWriter(OrderFilePath, false)) //do not append, everything is stored in the order file object
            {
                sw.Write(fileContents);
            }
        }

        public List<OrderModel> GetOrderHistory()
        {
            string fileContents;

                using (StreamReader sr = new StreamReader(OrderFilePath))
                {
                    fileContents = sr.ReadToEnd();
                }
       

            List<OrderModel> orderFile = JsonConvert.DeserializeObject<List<OrderModel>>(fileContents);

            if (orderFile == null){
                orderFile = new List<OrderModel>();
            }
            return orderFile;
        }

        public void AddOrder(OrderModel order)
        {
            //add to memory list
            List<OrderModel> OrderFile = GetOrderHistory();

            if (order != null)
            {
                OrderFile.Add(order);
            }

            //write that out
            WriteFile(OrderFile);
        }


        public bool WriteReport(List<OrderModel> OrderFile, string pathName)
        {
            using (StreamWriter sw = new StreamWriter(pathName, false))
            {
                //constitute line by line
                foreach (var order in OrderFile)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(order.Date.ToString("MM/dd/yyyy"));
                    sb.Append(" ");

                    sb.Append(order.Price.ToString("C"));
                    sb.Append(" ");

                    sb.Append(order.CustomerName);
                    sb.Append(" ");

                    sb.Append(order.Coffee.Name);
                    sb.Append("[");
                    sb.Append(order.Coffee.Price.ToString("C"));
                    sb.Append("]");
                    sb.Append(" ");


                    if (order.Coffee.Toppings != null)
                    {
                        foreach (var topping in order.Coffee.Toppings)
                        {
                            sb.Append(topping.Name);
                            sb.Append("[");
                            sb.Append(topping.Price.ToString("C"));
                            sb.Append("]");
                            sb.Append(" ");
                        }
                    }
                    else
                    {
                        sb.Append("no toppings/null toppings");
                    }


                    string reportLine = sb.ToString();
                    sw.WriteLine(reportLine);
                }
            }

            if (File.Exists(pathName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
