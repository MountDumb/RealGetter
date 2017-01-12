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
    public class Program
    {
        IStudentRepo rep;
        IList<IStudent> students;
        IStudent currentStudent;
        Sorting sort;


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Initialize();
            p.Update();
            p.Menu();
            Console.WriteLine(p.currentStudent.ToString());
            Console.ReadLine();
            //p.DoStuff();
            //p.Randomize();
            

                       
            //sort.Grouper(lint, 2);

            //Console.WriteLine(lint[0].GroupNumber);
            //Console.WriteLine(lint[1].GroupNumber);
            //Console.WriteLine(lint[2].GroupNumber);
            //Console.WriteLine(lint[3].GroupNumber);
            //Console.WriteLine(lint[4].GroupNumber);
            //Console.WriteLine(lint[5].GroupNumber);
            //Console.WriteLine(lint[6].GroupNumber);





            //Console.ReadLine();


        }

       

        void Initialize()
        {
            rep = DBService.GetCurrentClassOfStudents(new StudentRepo());
            students = new List<IStudent>(rep.GetStudents());
            sort = new Sorting();

          
            
            
        }

        void Menu()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1: Select a Student");
            Console.WriteLine("2: Create Student Groups");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("Choose Student Id");
                    ChooseCurrentStudent();
                    StudentMenu();
                    break;
                
                default:
                    Update();
                    Menu();
                    break;
            }
        }

        void StudentMenu()
        {
            Update();
            Console.WriteLine("Currently selected Student" + Environment.NewLine);
            Console.WriteLine(currentStudent.ShowCurrentStudentinfo() + Environment.NewLine);

            Console.WriteLine("Options:");
            Console.WriteLine("1: Create Student Comment");
            Console.WriteLine("x: Back" + Environment.NewLine);

            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("Comment: ");

                    foreach (var item in students)
                    {
                        if (item == currentStudent)
                        {
                            item.CurrentStudentInfo.SetComment(Console.ReadLine());
                        }
                    }
                    //currentStudent.CurrentStudentInfo.SetComment(Console.ReadLine());
                    Update();
                    StudentMenu();
                    break;

                case "x":
                    Menu();
                    break;

                default:
                    StudentMenu();
                    break;
            }
                
        }

        void ChooseCurrentStudent()
        {
            int choice = int.Parse(Console.ReadLine());

            foreach (var item in students)
            {
                if (item.StudentId == choice)
                {
                    currentStudent = item;

                }
            }
                
                       
        }
        void Update()
        {
            Console.Clear();
            Console.WriteLine("Current Class of Students:" + Environment.NewLine);
            ShowStudents();
            
        }

        void ShowStudents()
        {
            foreach (IStudent item in students)
            {
                Console.WriteLine(item.ToString());
                
            }

            Console.ReadLine();
        }

        void Randomize()
        {
            students = sort.Randomizer(students);
            Update();

        }

        void DoStuff()
        {
            //rep.GetStudents()[1].CurrentStudentInfo.SetComment("Han er træt");
            //Console.WriteLine(rep.GetStudents()[1].CurrentStudentInfo.Comment);
            students[1].CurrentStudentInfo.SetComment("Han er træt");
            Console.WriteLine(students[1].ShowCurrentStudentinfo());
            Console.ReadLine();
        }


    }

   
}
