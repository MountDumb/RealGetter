using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib
{
    public static class DBService
    {
        //private static string connectionString = "Server=ealdb1.eal.local; Database=ejl23_db; User=ejl23_usr; Password=Baz1nga23;";
        private static string connectionString = "Server=ealdb1.eal.local; Database=ejl09_db; User=ejl09_usr; Password=Baz1nga9;";

       
        public static IStudentRepo GetCurrentClassOfStudents(IStudentRepo students)
        {
            //IStudentRepo students = new StudentRepo();
            IStudent currentStudent;

            using (SqlConnection con = new SqlConnection(connectionString))
                try
                {

                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand("spGetStudents", con);
                    con.Open();
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        currentStudent = new Student();
                        //currentStudent.StudentId = int.Parse(myReader["StudentID"].ToString());
                        //((IPerson)currentStudent).FirstName = myReader["StudentFirstName"].ToString();
                        //((IPerson)currentStudent).LastName = myReader["StudentLastName"].ToString();
                        //currentStudent.ClassDesignation = myReader["ClassID"].ToString();
                        //((IPerson)currentStudent).SSN = myReader["StudentPersNr"].ToString();

                        currentStudent.CreateStudent(int.Parse(myReader["StudentID"].ToString()), 
                            myReader["StudentFirstName"].ToString(),
                            myReader["StudentLastName"].ToString(),
                            myReader["ClassID"].ToString(),
                            myReader["StudentPersNr"].ToString());
                      
                        students.AddNewStudent(currentStudent);
                        
                    }
                    return students;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            return students;
        }

        //using (SqlConnection con = new SqlConnection(connectionString))
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd1 = new SqlCommand("spInsertStudent", con);
        //        cmd1.CommandType = CommandType.StoredProcedure;
        //        cmd1.Parameters.Add("@StudentFirstName", SqlDbType.NVarChar);
        //        cmd1.Parameters["@StudentFirstName"].Value = "Lucas";
        //        cmd1.Parameters.Add(new SqlParameter("@StudentLastName", "Graham"));
        //        cmd1.Parameters.Add(new SqlParameter("@ClassID", 1));
        //        cmd1.Parameters.Add(new SqlParameter("@StudentPersNr", "0905924575"));


        //        cmd1.ExecuteNonQuery();





        //    }
        //    catch (SqlException e)
        //    {
        //        Console.WriteLine("Ooops, you got the following errormessage: " + e.Message);
        //    }
        //}

    }
}
