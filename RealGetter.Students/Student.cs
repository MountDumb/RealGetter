using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Students
{
    public class Student
    {
        //Fields
        private int _studentId;
        private string _firstName;
        //private string _middleName;
        private string _lastName;
        private string _phoneNumber;
        private string _eMail;

        //Constructors
        public Student(int studentId, string firstName, string lastName, string phoneNumber, string eMail)
        {
            _studentId = studentId;
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _eMail = eMail;
        }

        //Methods

            public void SetStudentId(int studInt)
        {
            _studentId = studInt;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public void SetEmail(string eMail)
        {

        }

        //Properties

        public int StudentID
        {
            get { return _studentId; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string lastName
        {
            get { return _lastName; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string EMail
        {
            get { return _eMail; }
        }
    }
}
