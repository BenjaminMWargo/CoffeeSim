using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoffeeSim
{
    public abstract class BaseFileManager
    {
        public bool OverwriteMode { get; set; }

        public BaseFileManager()
        {
            OverwriteMode = false; //DO NOT OVERWRITE BY DEFAULT
        }

        public abstract void Add();
        public abstract void Delete();

        public void DeleteFile(string filePath)
        {

        }


        


    }
}
