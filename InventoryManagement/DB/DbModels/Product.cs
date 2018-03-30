using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DbModels
{
    [Table("Product")]
    public class Product : BaseModel
    {
        [Required(ErrorMessage = "প্রোডাক্ট-এর নাম লিখতে হবে"), MinLength(3, ErrorMessage = "প্রোডাক্ট-এর নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "প্রোডাক্ট-এর নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম লিখুন")]
        public string Name { get; set; }
        [Required(ErrorMessage = "প্রোডাক্ট-এর সংখ্যা লিখতে হবে"), Column("CurrentStoreValue"), Display(Name = "প্রোডাক্ট-এর সংখ্যা", Prompt = "প্রোডাক্ট-এর প্রাথমিক সংখ্যা লিখুন"), Range(0, int.MaxValue, ErrorMessage = "মালের সঠিক প্রারম্ভিক স্থিথি লিখুন")]
        public int CurrentStoreValue { get; set; } = 0;

        [Column("ProductCategoryId"), Required(ErrorMessage = "প্রোডাক্ট-এর কেটাগরী সিলেক্ট করতে হবে"), Display(Name = "প্রোডাক্ট-এর কেটাগরী", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId"), Display(Name = "প্রোডাক্ট কেটাগরী", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public virtual ProductCategory ProductCategoryName { get; set; }

        [Column("ProductTypeId"), Required(ErrorMessage = "প্রোডাক্ট-এর টাইপ সিলেক্ট হবে"), Display(Name = "প্রোডাক্ট টাইপ", Prompt = "প্রোডাক্ট এর টাইপ সিলেক্ট করুন")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId"), Display(Name = "প্রোডাক্ট টাইপ", Prompt = "প্রোডাক্ট এর টাইপ সিলেক্ট করুন")]
        public virtual ProductType ProductTypeName { get; set; }
    }
}
