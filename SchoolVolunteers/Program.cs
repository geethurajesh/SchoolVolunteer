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
            var family = new Family();
            var volunteer = new Volunteer();
            var teacher = new Teacher();
            var classroom = new ClassRoom();


            #region
            ////for (int i=0;i<)
            //Console.Write("\n Enter Family Name: ");
            //family.FamilyName = Console.ReadLine();

            //Console.Write(" Enter Mother's Name: ");
            //family.MothersName = Console.ReadLine();

            //Console.Write(" Enter Father's Name: ");
            //family.FathersName = Console.ReadLine();

            //Console.Write(" Enter Child's Name: ");
            //family.Child1 = Console.ReadLine();

            //Console.Write(" Do want to add another Child?(Y/N) ");

            //char c = Console.ReadKey().KeyChar;
            //if (c == 'Y' || c == 'y')
            //{
            //    Console.Write("\n Enter Child's Name: ");
            //    family.Child2 = Console.ReadLine();

            //}
            //else
            //{
            //    Console.WriteLine("Thank you ");
            //}
            //Console.WriteLine(" ");
            #endregion
            family.FamilyID = 1001;
            family.Child2 = Console.ReadLine();
            family.FamilyName = "Diamonds";
            volunteer.Volunteering = 'Y';
            family.MothersName = "Ann";
            volunteer.Volunteering = 'N';
            family.FathersName = "Josh";
            family.Child1 = "Jack";
            teacher.TeacherFirstName = "Ms.Jackson";
            classroom.ClassroomName = "201";
                 // //class,
                // //grade
            family.Child2 = "Jill";

                // Teacher.
               // //grade
            School.AddFamily(family,volunteer,teacher, classroom); //calling the method
          //  School.AddFamily(volunteer);
           // family = new Family();
           // family.FamilyID = 12242;
           // family.FamilyName = "Smith";
           // family.MothersName = "Mary";
           // family.FathersName = "Finn";
           // family.Child1 = "Dian";
           // //class
           // //grade
           // family.Child2 = "May";
           // //child
           // //grade
           // School.AddFamily(family);
            School.DisplayFamily();
            Console.ReadKey();
        }
    }
}
