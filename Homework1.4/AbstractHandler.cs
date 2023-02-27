using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework1._4
{
    internal abstract class AbstractHandler
    {
        public abstract void Open();
       
        public abstract void Create();
        
        public abstract void Change();
        
        public abstract void Save();      
    }
}
