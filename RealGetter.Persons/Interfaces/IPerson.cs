using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib.Interfaces
{
    public interface IPerson
    {
        //int StudentId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Gender { get; set; }
        string SSN { get; set; }
        //string PhoneNumber { get; set; }
        //string EMail { get; set; }

   

    }
}
