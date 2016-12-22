﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib
{
    public class Student : Person, IStudent, IGroupNumber
    {
        #region Fields
        private int _studentId;

        private IStudentInfo _currentStudentInfo;

        
        #endregion

        #region Properties

        public IStudentInfo CurrentStudentInfo
        {
            get { return _currentStudentInfo; }
            set { _currentStudentInfo = value; }
        }

        public int StudentId
        {
            get { return _studentId;}
            set { _studentId = value; }
        }

        public string ClassDesignation
        {
            get; set;
        }



        public int GroupNumber { get; set; }

     
        #endregion

        #region Constructors
            public Student()
        {
            

        }
        public Student(int studentId, string firstName, string lastName, string ssn, IStudentInfo studentInfo)
        {
            _studentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = ssn;
            _currentStudentInfo = studentInfo;


        }
        #endregion

        #region Methods

        public void CreateStudent(int studentId, string firstName, string lastName, string ssn, string classDesignation)
        {
            _studentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.ClassDesignation = classDesignation;
        }

       

        public override string ToString()
        {
            return this.FirstName;
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
