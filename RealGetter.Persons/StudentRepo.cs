using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib
{
    public static class StudentRepo
    {
        public static string ClassDesignation
        {
            get; set;
        }

        private static List<Student> students;

        //public StudentRepo()
        //{
        //    students = new List<Student>();
        //}

        public static List<Student> GetStudents()
        {
            return students;
        }

        public static void AddNewStudent(Student student)
        {
            students.Add(student);
        }

        public static void RemoveStudent(Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == student.StudentId)
                {
                    students.RemoveAt(i);
                }

            }
        }

        public static void UpdateStudent(Student student)
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

