using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Libs
{
    public class StorageForGoogleDrive : IStorage
    {
        public void Save()
        {
            Console.WriteLine("Save to Google Drive");
        }
        public void Get()
        {
            Console.WriteLine("Get from Google Drive");
        }
    }
}
