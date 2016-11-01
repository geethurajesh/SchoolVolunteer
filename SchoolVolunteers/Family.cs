using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolVolunteers
{
    /// <summary>
    /// All families details
    /// </summary>
    public class Family
    {
        #region properties
        [Key]
        public int FamilyID { get; set; }
        public string FamilyName { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public string Child1 { get; set; }
        public string Child2 { get; set; }

        [ForeignKey("Volunteer")]
        public int VolunteerId { get; set; }
        ////we need the id to have acces to the volunteer id
        public virtual Volunteer Volunteer { get; set; }
        ////physically creating a relationship between the tables
        #endregion



    }
}
