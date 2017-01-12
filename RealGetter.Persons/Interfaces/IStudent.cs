using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib.Interfaces
{
    public interface IStudent
    {
        int StudentId { get; set; }

        int GroupNumber { get; set; }

        string ClassDesignation { get; set; }

        IStudentInfo CurrentStudentInfo { get; set; }

        void CreateStudent(int studentId, string firstName, string lastName, string ssn, string classDesignation);

        string ShowCurrentStudentinfo();


    }
}
