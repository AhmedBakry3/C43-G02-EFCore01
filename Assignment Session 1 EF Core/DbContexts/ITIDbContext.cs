using Assignment_Session_1_EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_Session_1_EF_Core.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        #region Constructors
        public ITIDbContext() : base()
        { }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =. ; Database = ITI ; Trusted_Connection = true ;  TrustServerCertificate = true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Course_ID, ci.Inst_Id }); // Composite PK For Course_Inst Table

            modelBuilder.Entity<Stud_Course>()
                .HasKey(ci => new { ci.Stud_Id, ci.Course_ID }); // Composite PK For Stud_Course Table
        }
        #endregion

        #region Properties
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public DbSet<Stud_Course> Studs_Courses { get; set; }
        public DbSet<Course_Inst> courses_Insts { get; set; } 
        #endregion

    }
}
