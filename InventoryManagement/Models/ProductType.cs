using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("ProductType")]
    public class ProductType
    {
        [HiddenInput(DisplayValue = false), Display(Name = "আই ডি")]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়"), Column("CreateTime")]
        public DateTime? CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়"), Column("LastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Column("Name"), Required, MinLength(3), MaxLength(50), Display(Name = "মালের ধরন", Prompt = "কি ধরনের মাল, তা লিখুন")]
        public string Name { get; set; }
    }
}
