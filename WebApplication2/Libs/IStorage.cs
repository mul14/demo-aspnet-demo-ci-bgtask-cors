using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Libs
{
    public interface IStorage
    {
        public void Save();
        public void Get();
    }
}
