using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib
{
    class StudentRepo
    {
        private List<Student> students;

        public StudentRepo()
        {
            students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddNewStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == student.StudentId)
                {
                    students.RemoveAt(i);
                }

            }
        }

        public void UpdateStudent(Student student)
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

