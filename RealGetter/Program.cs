using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Persons;
//using RealGetter.Interfaces;

namespace RealGetter

{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson testPerson = new Student(0, "Hugh", "Mungus", "66666666", "Kitty@cat.dog");
            Console.WriteLine(((IStudent)testPerson).StudentId);
            Console.WriteLine(testPerson.FirstName);
            Console.WriteLine(testPerson.LastName);
            Console.WriteLine(testPerson.PhoneNumber);
            Console.WriteLine(testPerson.EMail);
            Console.ReadLine();
        }

    }

   
}
