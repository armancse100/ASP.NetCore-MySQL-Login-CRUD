using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Product")]
    public class Product
    {
        [HiddenInput(DisplayValue = false), Display(Name = "আই ডি")]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়")]
        public DateTime CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়")]
        public DateTime LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Required, MinLength(3), MaxLength(50), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম লিখুন")]
        public string Name { get; set; }
        [Column("CurrentStoreValue"), Display(Name = "প্রোডাক্ট-এর সংখ্যা", Prompt = "প্রোডাক্ট-এর প্রাথমিক সংখ্যা লিখুন (ঐচ্ছিক )"), Range(UInt64.MinValue, UInt64.MaxValue)]
        public UInt64? CurrentStoreValue { get; set; } = 0;

        [Column("ProductCategoryId"), Required, Display(Name = "প্রোডাক্ট কেটাগরী", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategoryName { get; set; }

        [Column("ProductTypeId"), Required, Display(Name = "প্রোডাক্ট টাইপ", Prompt = "প্রোডাক্ট এর টাইপ সিলেক্ট করুন")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public virtual ProductType ProductTypeName { get; set; }
    }
}
