

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Courses")]
    internal class Course
    {

        #region By Convention
        public int Id { get; set; } //Pk with identity Constraint [1,1]
        //public Numeric Porperty Named As [Id , CourseId]
        //Automatically Assumed to be primary Key of the Table

        public decimal Duration { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null

        public string? Name { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null

        public string? Description { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null

        public int Top_ID { get; set; }
        //Value Type
        //Not Allow Null
        //int is Mapped to int , Not Allow Null 
        #endregion

        #region By Annontation
        [Key]
        public int CourseId { get; set; } //Pk with identity Constraint [1,1]

        [Column("CourseDuration" , TypeName = "decimal(10,2)")]
        public decimal Duration { get; set; }

        [Required]
        [Column("CourseName" , TypeName = "VarChar(50)")]
        public string? Name { get; set; }
        //Nullable Reference Type
        //string? is Mapped to NVarChar(Max) , Allow Null


        [Required]
        [Column("CourseDecription", TypeName = "VarChar(50)")]
        public string? Description { get; set; }
      

        public int Top_ID { get; set; }
        //Value Type
        //Not Allow Null
        //int is Mapped to int , Not Allow Null 
        #endregion
        
    }

}
