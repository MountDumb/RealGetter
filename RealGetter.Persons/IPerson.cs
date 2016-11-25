using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib
{
    public interface IPerson
    {
        //int StudentId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string EMail { get; set; }

   

    }
}
