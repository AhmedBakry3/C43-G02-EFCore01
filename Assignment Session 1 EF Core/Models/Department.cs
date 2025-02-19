
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Departments")]
    internal class Department
    {
        #region By Convention
        public int Id { get; set; } //Pk with identity Constraint [1,1]
        //public Numeric Porperty Named As [Id , DepartmentId]
        //Automatically Assumed to be primary Key of the Table

        public string? Name { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null

        public DateTime HiringDate { get; set; }
        //Nullable Reference Type
        //DateTime is Mapped to DateTime2(7) , Allow Null

        public int Ins_ID { get; set; }
        //Value Type
        //Not Allow Null
        //int is Mapped to int , Not Allow Null 
        #endregion

        #region By Annotation
        [Key]
        public int Id { get; set; } //Pk with identity Constraint [1,1]


        [Required]
        [Column("DepartmentAddress", TypeName = "VarChar")]
        [StringLength(70, MinimumLength = 3)] //Since that Min is an Application Validation , It will not be Mapped
        //Only Max (70) Will be Mapped
        public string? Name { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null

        [Column("StudentHiringDate", TypeName = "DateTime2")]
        public DateTime HiringDate { get; set; }

        [Column("Instructor_ID")]
        public int Ins_ID { get; set; }
         
        #endregion
    }
}
