using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoffeeSim.IOModels;
using Newtonsoft.Json;

namespace CoffeeSim
{
    public abstract class BaseFileManager
    {
        private string filePath;

        public BaseFileManager(string filePathIn)
        {
            if(!File.Exists(filePathIn))
            {
                File.Create(filePathIn);
            }

            filePath = filePathIn;
        }

        public void Add(BeverageModel beverage)
        {
            List<BeverageModel> temp = ReadData();

            temp.Add(beverage);

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                JsonConvert.SerializeObject(temp);
            }
        }

        public void Delete(string name)
        {
            List<BeverageModel> temp = ReadData();

            temp.RemoveAll(x => x.Name == name);

            using(StreamWriter writer = new StreamWriter(filePath, false))
            {
                JsonConvert.SerializeObject(temp);
            }
        }

        public void OverwriteFile(string newFilePath)
        {
            // Parse the given file into a beverage object, then format it in json
        }

        public List<BeverageModel> ReadData()
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                return JsonConvert.DeserializeObject<List<BeverageModel>>(reader.ReadToEnd());
            }
        }
    }
}
