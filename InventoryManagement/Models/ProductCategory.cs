using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("ProductCategory")]
    public class ProductCategory : BaseModel
    {
        [Column("Name"), Required(ErrorMessage = "মালের কাটাগরীর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "মালের কাটাগরীর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "মালের কাটাগরীর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "মালের কাটাগরীর নাম", Prompt = "মালের কাটাগরীর নাম লিখুন")]
        public string Name { get; set; }
    }
}
