
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Topics")]
    internal class Topic
    {
         #region By Convention

         public int Id { get; set; } //Pk with identity Constraint [1,1]
         //public Numeric Porperty Named As [ID , TopicId]
         //Automatically Assumed to be primary Key of the Table


         public string? Name { get; set; }
         //Nullable Reference Type
         //string? is Mapped to NVarChar(Max) , Allow Null
         #endregion

        #region By Annotation

        [Key]
        public int Id { get; set; } //Pk with identity Constraint [1,1]


        [Required]
        [Column("TopicNmae", TypeName = "VarChar")]
        [StringLength(50, MinimumLength = 3)] //Since that Min is an Application Validation , It will not be Mapped
        //Only Max (50) Will be Mapped
        public string? Name { get; set; }
       
        #endregion
    }
}
