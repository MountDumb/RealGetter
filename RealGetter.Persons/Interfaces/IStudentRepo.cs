using System.Collections.Generic;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib.Interfaces
{
    public interface IStudentRepo
    {
        

        void AddNewStudent(IStudent student);
        IList<IStudent> GetStudents();
        void RemoveStudent(IStudent student);
        void UpdateStudent(IStudent student);
    }
}