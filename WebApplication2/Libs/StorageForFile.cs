using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Libs
{
    public class StorageForFile : IStorage
    {
        public void Save()
        {
            Console.WriteLine("Save to file");
        }
        public void Get()
        {
            Console.WriteLine("Get from file");
        }
    }
}