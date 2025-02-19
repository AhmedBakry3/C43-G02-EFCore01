

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Instructors")]
    internal class Instructor
    {

        #region By Convention
        public int Id { get; set; } //Pk with identity Constraint [1,1]
        //public Numeric Porperty Named As [Id , InstructorId]
        //Automatically Assumed to be primary Key of the Table

        public string? Name { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null


        public decimal Bouns { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null

        public decimal Salary { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null

        public string? Address { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null

        public decimal HourRate { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null

        public int Dept_ID { get; set; }
        //Value Type
        //Not Allow Null
        //int is Mapped to int , Not Allow Null 
        #endregion


        #region By Convention
        [Key]
        public int Id { get; set; } //Pk with identity Constraint [1,1]



        [Required]
        [Column("InstructorName", TypeName = "VarChar")]
        [StringLength(50, MinimumLength = 3)] //Since that Min is an Application Validation , It will not be Mapped
        //Only Max (50) Will be Mapped
        public string? Name { get; set; }


        [Column("InstructorBouns", TypeName = "decimal(11,2)")]
        public decimal Bouns { get; set; }

        [Column("InstructorSalary", TypeName = "decimal(9,2)")]
        public decimal Salary { get; set; }

        [Required]
        [Column("InstructorAddress", TypeName = "VarChar")]
        [StringLength(100, MinimumLength = 3)] //Since that Min is an Application Validation , It will not be Mapped
        //Only Max (100) Will be Mapped
        public string Address { get; set; }
        

        [Column("InstructorHourRate", TypeName = "decimal(17,2)")]
        public decimal HourRate { get; set; }

        [Column("Department_ID")]
        public int Dept_ID { get; set; }
        
        #endregion
    }
}
