using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib;
using System.Data;
using System.Data.SqlClient;
//using RealGetter.Interfaces;

namespace RealGetter

{
    class Program
    {
        //private static string connectionString = "Server=ealdb1.eal.local; Database=ejl23_db; User=ejl23_usr; Password=Baz1nga23;";
        private static string connectionString = "Server=ealdb1.eal.local; Database=ejl09_db; User=ejl09_usr; Password=Baz1nga9;";

        static void Main(string[] args)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertStudent", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@StudentFirstName", SqlDbType.NVarChar);
                    cmd1.Parameters["@StudentFirstName"].Value = "Lucas";
                    cmd1.Parameters.Add(new SqlParameter("@StudentLastName", "Graham"));
                    cmd1.Parameters.Add(new SqlParameter("@ClassID", 1));
                    cmd1.Parameters.Add(new SqlParameter("@StudentPersNr", 05924575));

                    cmd1.ExecuteNonQuery();
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
                catch (SqlException e)
                {
                    Console.WriteLine("Ooops, you got the following errormessage: " + e.Message);
                }
            }
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

            Absence abs = new Absence();

            abs.DoStuff();

            Console.ReadLine();


        }

    }

   
}
