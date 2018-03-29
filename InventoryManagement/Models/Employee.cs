using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Employee")]
    public class Employee : BaseModel
    {
        [Required(ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "কর্মকর্তা/কর্মচারীর নাম", Prompt = "কর্মকর্তা/কর্মচারীর নাম লিখুন")]
        public string Name { get; set; }

        [Required(ErrorMessage = "অফিসের নাম লিখতে হবে"), MinLength(3, ErrorMessage = "অফিসের নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(200, ErrorMessage = "কর্মকর্তা/কর্মচারীর নাম ২০০ অক্ষরের ছোট হতে হবে"), Display(Name = "অফিসের নাম", Prompt = "অফিসের নাম লিখুন")]
        public string OfficeName { get; set; }
    }
}
