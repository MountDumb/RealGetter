using System.Collections.Generic;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib
{
    public interface IStudentRepo
    {
        string ClassDesignation { get; set; }

        void AddNewStudent(IStudent student);
        List<IStudent> GetStudents();
        void RemoveStudent(IStudent student);
        void UpdateStudent(IStudent student);
    }
}