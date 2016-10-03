using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}