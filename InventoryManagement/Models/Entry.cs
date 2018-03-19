using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Entry")]
    public class Entry
    {
        [HiddenInput(DisplayValue = false), Display(Name = "আই. ডি.")]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়"), Column("CreateTime")]
        public DateTime? CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়"), Column("LastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Column("EntryDate", TypeName = "DATE"), Required, Display(Name = "স্টোরে এন্ট্রির তারিখ", Prompt = "স্টোরে এন্ট্রির তারিখ সিলেক্ট করুন")]
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        [Column("InitialCount"), HiddenInput(DisplayValue = false), Display(Name = "পুর্বস্থিতি"), Range(0, int.MaxValue)]
        public int InitialCount { get; }
        [Column("NameOfSupplier"), Required, MinLength(3), MaxLength(100), Display(Name = "সরবরাহকারীর নাম", Prompt = "সরবরাহকারীর নাম লিখুন")]
        public string NameOfSupplier { get; set; }
        [Column("AddressOfSupplier", TypeName = "TEXT"), Required, MinLength(10), MaxLength(1000), Display(Name = "সরবরাহকারীর ঠিকানা", Prompt = "সরবরাহকারীর ঠিকানা লিখুন")]
        public string AddressOfSupplier { get; set; }

        [Column("ProductId"), Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম বাছাই করুন")]
        public virtual Product ProductName { get; set; }

        [Column("DescriptionOfProduct", TypeName = "TEXT"), Required, MinLength(10), MaxLength(3000), Display(Name = "মালের বিবরণ", Prompt = "মালের বিবরণ লিখুন")]
        public string DescriptionOfProduct { get; set; }
        [Column("NumberOfSuppliedProduct"), Required, Display(Name = "মালের পরিমান", Prompt = "মালের পরিমান লিখুন"), Range(0, int.MaxValue)]
        public int NumberOfSuppliedProduct { get; set; }
        [Column("SuppliedProductUnitPrice"), Required, Display(Name = "একক মুল্য", Prompt = "একক মুল্য লিখুন"), Range(float.MinValue, float.MaxValue)]
        public float SuppliedProductUnitPrice { get; set; }
    }
}
