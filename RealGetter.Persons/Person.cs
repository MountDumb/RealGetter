using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib
{
    public abstract class Person : IPerson
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string SSN { get; set; }
       
    }
}
