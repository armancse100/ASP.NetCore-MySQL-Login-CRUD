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
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়")]
        public DateTime CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়")]
        public DateTime LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Required, MinLength(3), MaxLength(50), Display(Name = "কর্মকর্তা/কর্মচারীর নাম", Prompt = "কর্মকর্তা/কর্মচারীর নাম লিখুন")]
        public string Name { get; set; }

        [Required, MinLength(3), MaxLength(200), Display(Name = "অফিসের নাম", Prompt = "অফিসের নাম লিখুন")]
        public string OfficeName { get; set; }
    }
}
