using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    class Page
    {
        [Key]
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
