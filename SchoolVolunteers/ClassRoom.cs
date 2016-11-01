using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVolunteers
{
    public class ClassRoom
    {
        #region Properties
        [Key]
        public int ClassId { get; set; }

        public string ClassroomName { get; set; }

        public int NumberOfKids { get; set; }
        #endregion

        //#region Db connection Properties
        //[ForeignKey("Teacher")]
        //public int TeacherID { get; set; }

        //public virtual Teacher Teacher { get; set; }

        //[ForeignKey("Volunteer")]
        //public int VolunteerID { get; set; }

        //public virtual Volunteer volunteer { get; set; }
        //#endregion
    }
}
