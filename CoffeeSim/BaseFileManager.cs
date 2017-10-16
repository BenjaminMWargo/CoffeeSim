using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoffeeSim.IOModels;
using Newtonsoft.Json;
using System.Collections;

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

        public bool Add(BeverageModel beverage)
        {
            List<BeverageModel> temp = ReadData();

            //Check if there's a duplicate in the list (by name)
            //If one exists, then don't add and return false
            if (temp.Any(x => x.Name.Equals(beverage.Name)))
            {
                return false;
            }

            temp.Add(beverage);



            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.Write(JsonConvert.SerializeObject(temp));
            }
            return true;
        }

        public void Delete(string name)
        {
            List<BeverageModel> temp = ReadData();

            temp.RemoveAll(x => x.Name == name);

            using(StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.Write(JsonConvert.SerializeObject(temp));
            }
        }

        public void OverwriteFile(string newFilePath)
        {
            // Parse the given file into a beverage object, then format it in json
            List<BeverageModel> beverages = ParseCSVFormat(newFilePath);

            // Bomb file away
            //File.Create(filePath);

            using (File.Create(filePath))
            {
                //hey :^)
            }
            
            foreach(var beverage in beverages)
            {
                Add(beverage);
            }

        }

        private List<BeverageModel> ParseCSVFormat(string path)
        {
            List<BeverageModel> beverages = new List<BeverageModel>();
            using (StreamReader reader = new StreamReader(path))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] components = str.Split(','); //slit based on comma separated values
                    if (components.Length > 1)
                    {
                        if(typeof(CoffeeFileManager) == this.GetType())
                        {
                            beverages.Add(new CoffeeModel(components[0], Decimal.Parse(components[1])));
                        }
                        else
                        {
                            beverages.Add(new ToppingModel(components[0], Decimal.Parse(components[1])));
                        }
                    }
                }
            }
            return beverages;
        }

        public List<BeverageModel> ReadData()
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                //WARNING: WIZARDRY AHEAD
                //You can't instantiate BeverageModel, because it is abstract
                //this makes sense, so instead, we'll use reflection to get the type of file manager
                //If it is ToppingsFileManager -> then deserialize the list as a List<ToppingModel> (that's what it manages)
                //Otherwise, it'll be CoffeeModels
                //then, cast to List<BeverageModel> using ToBevList (since there is no simple List<X> as List<Y> [and IList doesn't have .ConvertAll()])

                Type currType = this.GetType();

                if(typeof(ToppingsFileManager) == currType) 
                {
                    var bevList = GetList(typeof(ToppingModel));
                    bevList = JsonConvert.DeserializeObject<List<ToppingModel>>(reader.ReadToEnd());

                    if (bevList != null)
                    {
                        return ToBevList(bevList);
                    }
                    else
                    {
                        return new List<BeverageModel>();
                    }
                }
                else
                {
                    var bevList = GetList(typeof(CoffeeModel));
                    
                    bevList = JsonConvert.DeserializeObject<List<CoffeeModel>>(reader.ReadToEnd());

                    if (bevList != null)
                    {
                        return ToBevList(bevList);
                    }
                    else
                    {
                        return new List<BeverageModel>();
                    }
                }


            }
        }

        private List<BeverageModel> ToBevList(IList listOfModels)
        {
            List<BeverageModel> beverages = new List<BeverageModel>();
            foreach(var m in listOfModels)
            {
                beverages.Add(m as BeverageModel);
            }
            return beverages;
        }

        private IList GetList(Type type)
        {
            return (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(type));
        }
    }
}
