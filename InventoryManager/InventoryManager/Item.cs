using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InventoryManagerData
{
    public partial class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }
        [Required]
        [StringLength(100)]
        public string ItemDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal FactoryPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal FactoryDiscount { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemDiscount { get; set; }
        public int ImageId { get; set; }

        [ForeignKey(nameof(ImageId))]
        [InverseProperty("Items")]
        public virtual Image Image { get; set; }
    }
}
