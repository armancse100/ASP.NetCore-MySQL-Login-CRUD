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
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়"), Column("CreateTime")]
        public DateTime? CreateTime { get; } = (DateTime)DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়"), Column("LastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; } = (DateTime)DateTime.UtcNow;

        [Required, MinLength(3), MaxLength(50), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম লিখুন")]
        public string Name { get; set; }
        [Required, Column("CurrentStoreValue"), Display(Name = "প্রোডাক্ট-এর সংখ্যা", Prompt = "প্রোডাক্ট-এর প্রাথমিক সংখ্যা লিখুন"), Range(0, int.MaxValue)]
        public int CurrentStoreValue { get; set; } = 0;

        [Column("ProductCategoryId"), Required, Display(Name = "প্রোডাক্ট কেটাগরী", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId"), Display(Name = "প্রোডাক্ট কেটাগরী", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public virtual ProductCategory ProductCategoryName { get; set; }

        [Column("ProductTypeId"), Required, Display(Name = "প্রোডাক্ট টাইপ", Prompt = "প্রোডাক্ট এর টাইপ সিলেক্ট করুন")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId"), Display(Name = "প্রোডাক্ট টাইপ", Prompt = "প্রোডাক্ট এর টাইপ সিলেক্ট করুন")]
        public virtual ProductType ProductTypeName { get; set; }
    }
}
