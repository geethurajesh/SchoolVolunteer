namespace SchoolVolunteers
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolVolunteerModel : DbContext
    {
        // Your context has been configured to use a 'SchoolVolunteerModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SchoolVolunteers.SchoolVolunteerModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SchoolVolunteerModel' 
        // connection string in the application configuration file.
        public SchoolVolunteerModel()
            : base("name=SchoolVolunteerModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<ClassRoom> ClassRoom { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}