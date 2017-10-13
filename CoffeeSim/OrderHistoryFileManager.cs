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
                return orderHistory;
            }
            else
            {
                return orderHistory;
            }
        }


        public static void WriteFile(string filePath, OrderFileModel orderFile)
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

        public static OrderFileModel ReadFile(string filePath)
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



    }
}
