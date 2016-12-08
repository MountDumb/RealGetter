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
            IList<Student> lint = new List<Student>();
            lint.Add(new Student(1, "Casper", "", "", ""));
            lint.Add(new Student(1, "Mikkel", "", "", ""));
            lint.Add(new Student(1, "Peter", "", "", ""));
            lint.Add(new Student(1, "Torben", "", "", ""));
            lint.Add(new Student(1, "Christian", "", "", ""));
            lint.Add(new Student(1, "Delle", "", "", ""));
            lint.Add(new Student(1, "Bølle", "", "", ""));

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
