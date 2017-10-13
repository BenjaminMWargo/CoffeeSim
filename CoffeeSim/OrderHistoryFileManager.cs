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
        private static OrderFileModel OrderFile;
        private static string OrderFilePath;

        private OrderHistoryFileManager(string pathName)
        {
            //touch a file here?
            if (!File.Exists(pathName))
            {
                File.Create(pathName); //this doesn't actually do anything...
            }
        }

        public static OrderHistoryFileManager GetInstance(string pathName)
        {
            if(orderHistory == null)
            {
                orderHistory = new OrderHistoryFileManager(pathName);
                OrderFilePath = pathName;
                return orderHistory;
            }
            else
            {
                return orderHistory;
            }
        }


        private static void WriteFile(string filePath, OrderFileModel orderFile)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Order history file not found!");
            }
            else
            {
                string fileContents = JsonConvert.SerializeObject(orderFile);
                using (StreamWriter sw = new StreamWriter(filePath)) //do not append, everything is stored in the order file object
                {
                    sw.Write(fileContents);
                }
            }
        }

        private static OrderFileModel ReadFile(string filePath)
        {
            //check to see if the file is here
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Order history file not found!");
            }
            else
            {
                string fileContents;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileContents = sr.ReadToEnd();
                }
                OrderFileModel orderFile = JsonConvert.DeserializeObject<OrderFileModel>(fileContents);

                return orderFile;
            }
        }

        public static void AddOrder(OrderModel order)
        {
            //add to memory list
            OrderFile.Orders.Add(order);

            //write that out
            WriteFile(OrderFilePath, OrderFile);
        }

        public static bool WriteReport(string pathName)
        {
            using (StreamWriter sw = new StreamWriter(pathName, false))
            {
                //constitute line by line
                foreach(var order in OrderFile.Orders)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(order.Date.ToString("mm/dd/yyyy"));
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

                    foreach(var topping in order.Coffee.Toppings)
                    {
                        sb.Append(topping.Name);
                        sb.Append("[");
                        sb.Append(topping.Price.ToString("C"));
                        sb.Append("]");
                        sb.Append(" ");
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
