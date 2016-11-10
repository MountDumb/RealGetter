using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Interfaces
{
    public interface IPerson
    {
        int StudentId { get; }
        string FirstName { get; }
        string LastName { get; }
        string PhoneNumber { get; }
        string EMail { get; }

        void SetStudentId(int studId);
        void SetFirstName(string firstName);
        void SetLastName(string lastName);
        void SetPhoneNumber(string phoneNumber);
        void SetEMail(string eMail);

    }
}
