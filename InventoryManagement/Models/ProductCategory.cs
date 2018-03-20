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
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়"), Column("CreateTime")]
        public DateTime? CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়"), Column("LastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Column("Name"), Required(ErrorMessage = "মালের কাটাগরীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "মালের কাটাগরীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "মালের কাটাগরীর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "মালের কাটাগরীর নাম", Prompt = "মালের কাটাগরীর নাম লিখুন")]
        public string Name { get; set; }
    }
}
