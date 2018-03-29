using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("ProductType")]
    public class ProductType : BaseModel
    {
        [Column("Name"), Required(ErrorMessage = "কি ধরনের মাল, তা লিখতে হবে"), MinLength(3, ErrorMessage = "মালের ধরন ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "মালের ধরন ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "মালের ধরন", Prompt = "কি ধরনের মাল, তা লিখুন")]
        public string Name { get; set; }
    }
}
