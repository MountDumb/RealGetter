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

           


            //Sorting sort = new Sorting();
            //IList<Student> lint = new List<Student>();
            //lint.Add(new Student(1, "Casper", "", "", new StudentInfo() ));
            //lint.Add(new Student(1, "Mikkel", "", "", new StudentInfo()));
            //lint.Add(new Student(1, "Peter", "", "", new StudentInfo()));
            //lint.Add(new Student(1, "Torben", "", "", new StudentInfo()));
            //lint.Add(new Student(1, "Christian", "", "", new StudentInfo()));
            //lint.Add(new Student(1, "Delle", "", "", new StudentInfo()));
            //lint.Add(new Student(1, "Bølle", "", "", new StudentInfo()));

            //lint = sort.Randomizer(lint);
            //Console.WriteLine(lint[0].ToString());
            //Console.WriteLine(lint[1].ToString());
            //Console.WriteLine(lint[2].ToString());
            //Console.WriteLine(lint[3].ToString());
            //Console.WriteLine(lint[4].ToString());
            //Console.WriteLine(lint[5].ToString());
            //Console.WriteLine(lint[6].ToString());
            //Console.ReadLine();

            //sort.Grouper(lint, 2);

            //Console.WriteLine(lint[0].GroupNumber);
            //Console.WriteLine(lint[1].GroupNumber);
            //Console.WriteLine(lint[2].GroupNumber);
            //Console.WriteLine(lint[3].GroupNumber);
            //Console.WriteLine(lint[4].GroupNumber);
            //Console.WriteLine(lint[5].GroupNumber);
            //Console.WriteLine(lint[6].GroupNumber);

            

            Console.ReadLine();

            //Sorting sort = new Sorting();
            //IList<Student> lint = new List<Student>();
            //lint.Add(new Student(1, "Casper", "", "", ""));
            //lint.Add(new Student(1, "Mikkel", "", "", ""));
            //lint.Add(new Student(1, "Peter", "", "", ""));
            //lint.Add(new Student(1, "Torben", "", "", ""));
            //lint.Add(new Student(1, "Christian", "", "", ""));
            //lint.Add(new Student(1, "Delle", "", "", ""));
            //lint.Add(new Student(1, "Bølle", "", "", ""));

            //con.Open();
            //SqlCommand cmd1 = new SqlCommand("InsertPet", con);
            //cmd1.CommandType = CommandType.StoredProcedure;
            //cmd1.Parameters.Add("@Petname", SqlDbType.NVarChar);
            //cmd1.Parameters["@PetName"].Value = "Kalle";
            //cmd1.Parameters.Add(new SqlParameter("@PetType", "Kalle"));
            //cmd1.Parameters.Add(new SqlParameter("@PetBreed", "Kalle"));
            //cmd1.Parameters.Add(new SqlParameter("@PetDOB", DateTime.Now));
            //cmd1.Parameters.Add(new SqlParameter("@PetWeight", 2.54m));

            //cmd1.ExecuteNonQuery();
        }

    }

   
}
