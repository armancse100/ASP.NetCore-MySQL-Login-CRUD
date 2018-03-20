using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Employee")]
    public class Employee
    {
        [HiddenInput(DisplayValue = false), Display(Name = "আই ডি")]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়"), Column("CreateTime")]
        public DateTime? CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়"), Column("LastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "কর্মকর্তা/কর্মচারীর নাম", Prompt = "কর্মকর্তা/কর্মচারীর নাম লিখুন")]
        public string Name { get; set; }

        [Required(ErrorMessage = "অফিসের নাম লিখতে হবে"), MinLength(3, ErrorMessage = "অফিসের নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(200, ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম ২০০ অক্ষরের ছোট হতে হবে"), Display(Name = "অফিসের নাম", Prompt = "অফিসের নাম লিখুন")]
        public string OfficeName { get; set; }
    }
}
