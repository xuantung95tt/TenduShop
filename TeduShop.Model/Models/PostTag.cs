using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    internal class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        public int TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}