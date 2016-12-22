using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib
{
    public class StudentRepo : IStudentRepo
    {
        public string ClassDesignation
        {
            get; set;
        }

        private List<IStudent> students;

        public StudentRepo()
        {
            students = new List<IStudent>();
        }

        public  List<IStudent> GetStudents()
        {
            return students;
        }

        public void AddNewStudent(IStudent student)
        {
            students.Add(student);
        }

        public void RemoveStudent(IStudent student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == student.StudentId)
                {
                    students.RemoveAt(i);
                }

            }
        }

        public void UpdateStudent(IStudent student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == student.StudentId)
                {
                    students[i] = student;
                }
            }
        }
    }
}

