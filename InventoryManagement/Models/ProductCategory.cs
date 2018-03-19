using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        [HiddenInput(DisplayValue = false), Display(Name = "আই ডি")]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়")]
        public DateTime CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়")]
        public DateTime LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Column("Name"), Required, MinLength(3), MaxLength(50), Display(Name = "মালের কাটাগরীর নাম", Prompt = "মালের কাটাগরীর নাম লিখুন")]
        public string Name { get; set; }
    }
}
