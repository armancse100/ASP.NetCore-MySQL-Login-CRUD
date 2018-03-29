using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    public class Exit : BaseModel
    {
        [Column("ReceiveDate", TypeName = "DATE"), Required(ErrorMessage = "মাল গ্রহনের তারিখ সিলেক্ট করতে হবে"), Display(Name = "মাল গ্রহনের তারিখ", Prompt = "মাল গ্রহনের তারিখ সিলেক্ট করুন")]
        public DateTime ReceiveDate { get; set; } = DateTime.UtcNow;
        [Column("NameOfUser"), Required(ErrorMessage = "গ্রহণকারীর নাম লিখতে হবে"), MinLength(3), MaxLength(100), Display(Name = "গ্রহণকারীর নাম", Prompt = "গ্রহণকারীর নাম লিখুন")]
        public string NameOfUser { get; set; }
        [Column("AddressOfUser", TypeName = "TEXT"), Required(ErrorMessage = "গ্রহণকারীর ঠিকানা লিখতে হবে"), MinLength(10), MaxLength(1000), Display(Name = "গ্রহণকারীর ঠিকানা", Prompt = "গ্রহণকারীর ঠিকানা লিখুন")]
        public string AddressOfUser { get; set; }
        [Column("DemandnoteNo"), Required(ErrorMessage = "চাহিদা পত্র নম্বর লিখতে হবে"), MinLength(5), MaxLength(100), Display(Name = "চাহিদা পত্র নং", Prompt = "চাহিদা পত্র নম্বর লিখুন")]
        public string DemandNoteNo { get; set; }

        [Column("ProductId"), Required(ErrorMessage = "প্রোডাক্ট-এর নাম বাছাই করতে হবে"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম বাছাই করুন")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম বাছাই করুন")]
        public virtual Product ProductName { get; set; }

        [Column("NumberOfReceivedProduct"), Required(ErrorMessage = "মালের পরিমান লিখতে হবে"), Display(Name = "মালের পরিমান", Prompt = "মালের পরিমান লিখুন"), Range(int.MinValue, int.MaxValue, ErrorMessage = "মালের সঠিক পরিমান লিখুন")]
        public int NumberOfReceivedProduct { get; set; }
        [Column("TotalNoOfProductAfterdeduction"), Display(Name = "অবশিষ্ট মালের পরিমান"), Range(0, int.MaxValue)]
        public int TotalNoOfProductAfterdeduction { get; set; }

        [Column("EntryId"), Display(Name = "এন্ট্রি আইডি রেফেরান্স (অপসনাল)", Prompt = "এন্ট্রি আই.ডি. সিলেক্ট করুন")]
        public int? EntryId { get; set; }
        [ForeignKey("EntryId"), Display(Name = "এন্ট্রি আইডি রেফেরান্স (অপসনাল)", Prompt = "এন্ট্রি আই.ডি. সিলেক্ট করুন")]
        public virtual Entry Entry { get; set; }
    }
}
