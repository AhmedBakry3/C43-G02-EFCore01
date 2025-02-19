

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Studs_Courses")]
    internal class Stud_Course
    {
        #region By Convention
        public int Stud_Id { get; set; } //Pk with identity Constraint [1,1]
        //public Numeric Porperty Named As [ID , Stud_CourseId]
        //Automatically Assumed to be primary Key of the Table

        public int Course_ID { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null

        public int Grade { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null 
        #endregion

        #region By Annotation

        [Key]
        [Column(Order = 1)] // use to specify the order in the composite key
        public int Stud_Id { get; set; }

        [Key]
        [Column(Order = 2)] // use to specify the order in the composite key
        public int Course_ID { get; set; }

        [Column("SutdentGrade")]
        public int Grade { get; set; }
        
        #endregion
    }
}
