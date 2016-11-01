using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteers
{ /// <summary>
  ///A class for teachers and all the Teachers in school.
  /// In this class we will have db to store the Teacher details and we will be able to take teachers list
  /// if require or Teacher list. I am also planning to have a different class for Classroom where i 
  /// should be able to search for a class room and see the details of the class like teachers name
  /// number of students volunteers signed up to that class
  /// </summary>


    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public string TeacherFirstName { get; set; }

        // public string TeacherLastName { get; set; }

        [ForeignKey("Volunteer")]
        public int VolunteerId { get; set; }
        ////we need the id to have acces to the volunteer id
        public virtual Volunteer Volunteer { get; set; }
        ////physically creating a relationship between the tables







    }
}
