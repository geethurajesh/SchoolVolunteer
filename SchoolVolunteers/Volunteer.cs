using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVolunteers
{
    public class Volunteer
    {
        [Key]
        public int VolunteerId { get; set; }
        public char Volunteering { get; set; }
        //  public virtual ICollection<Family> Families { get; set; }




        [ForeignKey("Family")]
        public int FamilyId { get; set; }
        //we need the id to have acces to the volunteer id
        public virtual Family Family { get; set; }
        //physically creating a relationship between the tables

        public virtual ICollection<Teacher> Teachers { get; set; }


    }
}
