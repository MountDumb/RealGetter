using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib;
//using RealGetter.Interfaces;

namespace RealGetter

{
    class Program
    {
        static void Main(string[] args)
        {
            //IPerson testPerson = new Student(0, "Hugh", "Mungus", "66666666", "Kitty@cat.dog");
            //Console.WriteLine(((IStudent)testPerson).StudentId);
            //Console.WriteLine(testPerson.FirstName);
            //Console.WriteLine(testPerson.LastName);
            //Console.WriteLine(testPerson.PhoneNumber);
            //Console.WriteLine(testPerson.EMail);
            //Console.ReadLine();

            Sorting sort = new Sorting();
            List<Student> lint = new List<Student>();
            lint.Add(new Student());
            lint.Add(new Student());
            lint.Add(new Student());
            lint.Add(new Student());
            lint.Add(new Student());
            lint.Add(new Student());
            lint.Add(new Student());

            sort.Randomizer(lint);
            Console.WriteLine(lint[0]);
            Console.WriteLine(lint[1]);
            Console.WriteLine(lint[2]);
            Console.WriteLine(lint[3]);
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
