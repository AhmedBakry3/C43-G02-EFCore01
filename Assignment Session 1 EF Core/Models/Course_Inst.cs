using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Courses_Insts")]

    internal class Course_Inst
    {

        #region By Convention
        public int Inst_Id { get; set; } //Pk with identity Constraint [1,1]
        //public Numeric Porperty Named As [Id , Course_InstId]
        //Automatically Assumed to be primary Key of the Table

        public int Course_ID { get; set; }
        //Value Type
        //Not Allow Null
        //int is Mapped to int , Not Allow Null

        public decimal Evaluate { get; set; }
        //Value Type
        //Not Allow Null
        //decimal is Mapped to decimal(18,2) , Not Allow Null

        #endregion

        #region By Annotation

        [Key]
        [Column(Order = 1)] // use to specify the order in the composite key
        public int Inst_Id { get; set; } 

        [Key]
        [Column(Order = 2)] // use to specify the order in the composite key
        public int Course_ID { get; set; }


        [Column("Course_Inst_Evaluate", TypeName = "decimal(10,2)")]
        public decimal Evaluate { get; set; }


        #endregion
    }
}
