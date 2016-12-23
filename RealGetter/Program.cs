using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib;
using RealGetter.Lib.ToolBox;
using RealGetter.Lib.Interfaces;
using System.Data;
using System.Data.SqlClient;


namespace RealGetter

{
    class Program
    {
   

        static void Main(string[] args)
        {
            IStudentRepo rep = DBService.GetCurrentClassOfStudents(new StudentRepo());

            foreach (IStudent item in rep.GetStudents())
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(((IPerson)item).LastName);
            }

            Console.ReadLine();



            Sorting sort = new Sorting();
            IList<Student> lint = new List<Student>();
            lint.Add(new Student(1, "Casper", "", "", new StudentInfo()));
            lint.Add(new Student(1, "Mikkel", "", "", new StudentInfo()));
            lint.Add(new Student(1, "Peter", "", "", new StudentInfo()));
            lint.Add(new Student(1, "Torben", "", "", new StudentInfo()));
            lint.Add(new Student(1, "Christian", "", "", new StudentInfo()));
            lint.Add(new Student(1, "Delle", "", "", new StudentInfo()));
            lint.Add(new Student(1, "Bølle", "", "", new StudentInfo()));

            lint = sort.Randomizer(lint);
            Console.WriteLine(lint[0].ToString());
            Console.WriteLine(lint[1].ToString());
            Console.WriteLine(lint[2].ToString());
            Console.WriteLine(lint[3].ToString());
            Console.WriteLine(lint[4].ToString());
            Console.WriteLine(lint[5].ToString());
            Console.WriteLine(lint[6].ToString());
            Console.ReadLine();

            sort.Grouper(lint, 2);

            Console.WriteLine(lint[0].GroupNumber);
            Console.WriteLine(lint[1].GroupNumber);
            Console.WriteLine(lint[2].GroupNumber);
            Console.WriteLine(lint[3].GroupNumber);
            Console.WriteLine(lint[4].GroupNumber);
            Console.WriteLine(lint[5].GroupNumber);
            Console.WriteLine(lint[6].GroupNumber);





            Console.ReadLine();

            
        }

    }

   
}
