using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        [MaxLength(50)]
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(500)]
        public string MetaDescription { get; set; }
        [MaxLength(500)]
        public string MetaKeyword { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}