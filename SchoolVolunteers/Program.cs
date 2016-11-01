using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteers

{
    public class Program
    {
         static void Main(string[] args)
        {
            #region properties
            var family = new Family();
            var volunteer = new Volunteer();
            var teacher = new Teacher();
            var classroom = new ClassRoom();
            var choice = 0;
            #endregion

            Console.WriteLine(" \n    Welcome to Ideal School Volunteer Form   \n\n ");
            bool invalidChoice = false;
            while (choice != 6 || invalidChoice)
            {
                Console.WriteLine("1. Add new Family  ");
                Console.WriteLine("2. Display Family details");

                Console.WriteLine("3. Add new Teachers  ");
                Console.WriteLine("4. Display Teachers details");

                Console.WriteLine("5. Display Volunteers details");
                Console.WriteLine("6. Exit\n");

                Console.Write("Please Choose an Option : ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    invalidChoice = true;
                    Console.WriteLine("**********    Invalid choice!    \n *********    Choose an option from the menu.    ");
                    continue;

                }
                invalidChoice = false;
                Console.WriteLine(choice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Family Name : ");
                        family.FamilyName = Console.ReadLine();

                        Console.WriteLine("Enter Mother's Name : ");
                        family.MothersName = Console.ReadLine();

                        Console.WriteLine("Enter Father's Name : ");
                        family.FathersName = Console.ReadLine();

                        Console.WriteLine("Enter First Child's Name : ");
                        family.Child1 = Console.ReadLine();

                        Console.WriteLine("Enter Second Child's Name : ");
                        family.FamilyName = Console.ReadLine();

                       // School.AddFamily(family);
                        //Console.WriteLine("choice 1\n");
                        break;
                    case 2:
                        School.DisplayFamily();
                        //Console.WriteLine("choice 2\n");

                        break;
                    case 3:

                        Console.Write("Enter Authorisation code :");
                        var ACode = Console.ReadLine();
                        var RequiredCode = "AABB";
                        if (ACode != RequiredCode)
                        {
                            Console.WriteLine("Incorrect Password")
                                break;
                        }
                        else
                        {
                            Console.WriteLine(" Enter Teachers First Name");
                            teacher.TeacherFirstName = Console.ReadLine();
                            School.AddTeachers(teacher);

                        }
            

                        break;
                    case 4:
                        Console.WriteLine("choice 4\n");

                        break;
                    case 5:
                        Console.WriteLine("choice 5\n");
                        break;
                    default:
                        Console.WriteLine("choice 6\n");

                        break;
                }
            }

           
           
             // School.AddFamily(family);
            
            ;
            Console.ReadKey(); 
        }
    }
}
