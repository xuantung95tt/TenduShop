using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    internal class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        public int TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}