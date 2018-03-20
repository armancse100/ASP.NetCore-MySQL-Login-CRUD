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

        [Column("EntryDate", TypeName = "DATE"), Required(ErrorMessage = "স্টোরে এন্ট্রির তারিখ সিলেক্ট করতে হবে"), Display(Name = "স্টোরে এন্ট্রির তারিখ", Prompt = "স্টোরে এন্ট্রির তারিখ সিলেক্ট করুন")]
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        [Column("InitialCount"), HiddenInput(DisplayValue = false), Display(Name = "পুর্বস্থিতি"), Range(0, int.MaxValue)]
        public int InitialCount { get; }
        [Column("NameOfSupplier"), Required(ErrorMessage = "সরবরাহকারীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "সরবরাহকারীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(100, ErrorMessage = "সরবরাহকারীর নাম ১০০ অক্ষরের ছোট হতে হবে"), Display(Name = "সরবরাহকারীর নাম", Prompt = "সরবরাহকারীর নাম লিখুন")]
        public string NameOfSupplier { get; set; }
        [Column("AddressOfSupplier", TypeName = "TEXT"), Required(ErrorMessage = "সরবরাহকারীর ঠিকানা লিখতে হবে"), MinLength(10, ErrorMessage = "সরবরাহকারীর ঠিকানা ১০ অক্ষরের বড় হতে হবে"), MaxLength(1000, ErrorMessage = "সরবরাহকারীর ঠিকানা ১০০০ অক্ষরের ছোট হতে হবে"), Display(Name = "সরবরাহকারীর ঠিকানা", Prompt = "সরবরাহকারীর ঠিকানা লিখুন")]
        public string AddressOfSupplier { get; set; }

        [Column("ProductId"), Required(ErrorMessage = "প্রোডাক্ট-এর নাম লিখতে হবে"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম বাছাই করুন")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম বাছাই করুন")]
        public virtual Product ProductName { get; set; }

        [Column("DescriptionOfProduct", TypeName = "TEXT"), Required(ErrorMessage = "মালের বিবরণ লিখতে হবে"), MinLength(10, ErrorMessage = "মালের বিবরণ ১০ অক্ষরের বড় হতে হবে"), MaxLength(3000, ErrorMessage = "মালের বিবরণ ১০০০ অক্ষরের ছোট হতে হবে"), Display(Name = "মালের বিবরণ", Prompt = "মালের বিবরণ লিখুন")]
        public string DescriptionOfProduct { get; set; }
        [Column("NumberOfSuppliedProduct"), Required(ErrorMessage = "মালের পরিমান লিখতে হবে"), Display(Name = "মালের পরিমান", Prompt = "মালের পরিমান লিখুন"), Range(0, int.MaxValue, ErrorMessage = "মালের সঠিক পরিমান লিখুন")]
        public int NumberOfSuppliedProduct { get; set; }
        [Column("SuppliedProductUnitPrice"), Required(ErrorMessage = "মালের একক মুল্য লিখতে হবে"), Display(Name = "একক মুল্য", Prompt = "একক মুল্য লিখুন"), Range(0, float.MaxValue, ErrorMessage = "মালের সঠিক একক মুল্য লিখুন")]
        public float SuppliedProductUnitPrice { get; set; }
    }
}
