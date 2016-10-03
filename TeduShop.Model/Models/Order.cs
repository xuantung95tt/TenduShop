﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(500)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(500)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { get; set; }

        [MaxLength(500)]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [MaxLength(500)]
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}