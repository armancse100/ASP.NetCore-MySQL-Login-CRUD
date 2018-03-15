using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Employee")]
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime? CreateTime { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int Salary { get; set; }

        public Employee()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
