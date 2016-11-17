using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RealGetter.Interfaces;

namespace RealGetter.Persons
{
    public class Student : Person, IStudent
    {
        #region Fields
        //private int _studentId;

        #endregion

        #region Properties

        public int StudentId
        {
            get; set;
        }

        //public string FirstName
        //{
        //    get; 
        //}

        //public string LastName
        //{
        //    get;
        //}

        //public string PhoneNumber
        //{
        //    get;
        //}

        //public string EMail
        //{
        //    get;
        //}
        #endregion

        #region Constructors
        public Student(int studentId, string firstName, string lastName, string phoneNumber, string eMail)
        {
            this.StudentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
        }
        #endregion

        #region Methods

       

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
