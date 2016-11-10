using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Interfaces;

namespace RealGetter.Students
{
    public class Student : IPerson
    {
        #region Fields
        private int _studentId;
        private string _firstName;
        //private string _middleName;
        private string _lastName;
        private string _phoneNumber;
        private string _eMail;
        #endregion

        #region Properties
        //Properties

        public int StudentId
        {
            get { return _studentId; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
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
        #endregion

        #region Constructors
        public Student(int studentId, string firstName, string lastName, string phoneNumber, string eMail)
        {
            this.SetStudentId(studentId);
            this.SetFirstName(firstName);
            this.SetLastName(lastName);
            this.SetPhoneNumber(phoneNumber);
            this.SetEMail(eMail);
        }
        #endregion

        #region Methods

        public void SetStudentId(int studId)
        {
            _studentId = studId;
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

        public void SetEMail(string eMailString)
        {
            //Validates that that the EMail String is a single word 
            //and that it contains a '@' followed by a '.' 
            //Needs cleaning up (three possible exceptions thrown). 
            char[] validationarray = eMailString.ToCharArray();

            if (!validationarray.Contains(';') && !validationarray.Contains(' '))
            {
                for (int i = 0; i < validationarray.Length; i++)
                {
                    if (validationarray[i] == '@')
                    {
                        for (int ii = i + 1; ii < validationarray.Length; ii++)
                        {
                            if (validationarray[ii] == '.')
                            {
                                _eMail = eMailString;
                            }
                            else
                            {
                                throw new Exception("Invalid Email address");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid Email address");
                    }

                }
            }
            else
            {
                throw new Exception("Invalid Email address");
            }

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

    }
}
