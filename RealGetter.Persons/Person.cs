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
        //public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Gender { get; set; }
        public string SSN { get; set; }
        //public string PhoneNumber { get; set; }
        //public string EMail { get; set; }
       
    }
}
