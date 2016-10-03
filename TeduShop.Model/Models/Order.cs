using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    internal class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerMobile { get; set; }

        [MaxLength(500)]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [MaxLength(500)]
        public string PaymentMethod { get; set; }

        [Required]
        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}