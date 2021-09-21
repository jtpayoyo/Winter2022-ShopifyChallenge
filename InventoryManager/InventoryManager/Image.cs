using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InventoryManagerData
{
    public partial class Image
    {
        public Image()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public int ImageId { get; set; }
        [Required]
        [StringLength(40)]
        public string ImageName { get; set; }
        [Required]
        [StringLength(5)]
        public string ImageFormat { get; set; }
        [Required]
        public byte[] ImageFile { get; set; }

        [InverseProperty(nameof(Item.Image))]
        public virtual ICollection<Item> Items { get; set; }
    }
}
