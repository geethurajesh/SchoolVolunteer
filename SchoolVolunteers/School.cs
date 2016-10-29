using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteers
{/// <summary>
/// 
/// </summary>
    static public class School
    {
        #region properties
       // [Key]
        public static string SchoolName { get; set; }

        public static string SchoolAddress { get; set; }

        public static string TeachersFName { get; set; }

        public static int TeachersLName { get; set; }
        //public string Kids { get; set; }

       
        #endregion

        #region Methods
        /// <summary>
        /// adding each family to the family list with this method
        /// </summary>
        /// <param name="family"></param>
        /// 

        public static void AddFamily(Family family, Volunteer volunteer,Teacher Teacher, ClassRoom classroom)
        {
            using (var Model = new SchoolVolunteerModel())
            {
                //Model is the connection name and we are creating an instance of the database connection
                //"using " is used to end the scope of the Datebase (closing the db)
                Model.Families.Add(family);
                Model.Volunteers.Add(volunteer);
                Model.Teachers.Add(Teacher);
                Model.ClassRoom.Add(classroom);
                Model.SaveChanges();
            }//by this time the database connection is terminated
        }

        
        /// <summary>
        /// Print the family details 
        /// </summary>
        public static void DisplayFamily()
        {
            using (var model = new SchoolVolunteerModel())
            { 
                foreach (var family in model.Families)
                {
                    Console.WriteLine("FamilyName: {0}\n,MothersName: {1}\n,FathersName: {2}\n,Child1 :{3}\n,Child2: {4}\n\n", family.FamilyName, family.MothersName, family.FathersName, family.Child1, family.Child2);

                }
            }
        }
        #endregion
    }
}
