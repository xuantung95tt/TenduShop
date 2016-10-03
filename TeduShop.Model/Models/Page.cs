using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    internal class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Content { get; set; }
        public bool Status { get; set; }

        [MaxLength(500)]
        public string MetaKeyword { get; set; }

        [MaxLength(500)]
        public string MetaDescription { get; set; }
    }
}