using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    public class Exit
    {
        [HiddenInput(DisplayValue = false), Display(Name = "আই. ডি.")]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false), Display(Name = "প্রথম এন্ট্রির সময়"), Column("CreateTime")]
        public DateTime? CreateTime { get; } = DateTime.UtcNow;
        [HiddenInput(DisplayValue = false), Display(Name = "শেষ হালনাগাদের সময়"), Column("LastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; } = DateTime.UtcNow;

        [Column("ReceiveDate", TypeName = "DATE"), Required, Display(Name = "মাল গ্রহনের তারিখ", Prompt = "মাল গ্রহনের তারিখ সিলেক্ট করুন")]
        public DateTime ReceiveDate { get; set; } = DateTime.UtcNow;
        [Column("NameOfUser"), Required, MinLength(3), MaxLength(100), Display(Name = "গ্রহণকারীর নাম", Prompt = "গ্রহণকারীর নাম লিখুন")]
        public string NameOfUser { get; set; }
        [Column("AddressOfUser", TypeName = "TEXT"), Required, MinLength(10), MaxLength(1000), Display(Name = "গ্রহণকারীর ঠিকানা", Prompt = "গ্রহণকারীর ঠিকানা লিখুন")]
        public string AddressOfUser { get; set; }
        [Column("DemandnoteNo"), Required, MinLength(5), MaxLength(100), Display(Name = "চাহিদা পত্র নং", Prompt = "চাহিদা পত্র নম্বর লিখুন")]
        public string DemandNoteNo { get; set; }

        [Column("ProductId"), Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId"), Display(Name = "প্রোডাক্ট-এর নাম", Prompt = "প্রোডাক্ট-এর নাম বাছাই করুন")]
        public virtual Product ProductName { get; set; }

        [Column("NumberOfReceivedProduct"), Required, Display(Name = "মালের পরিমান", Prompt = "মালের পরিমান লিখুন"), Range(UInt64.MinValue, UInt64.MaxValue)]
        public int NumberOfReceivedProduct { get; set; }
        [Column("TotalNoOfProductAfterdeduction"), HiddenInput(DisplayValue = false), Display(Name = "অবশিষ্ট মালের পরিমান"), Range(0, int.MaxValue)]
        public int TotalNoOfProductAfterdeduction { get; set; }

        [Column("EntryId"), Display(Name = "এন্ট্রি আই ডি", Prompt = "এন্ট্রি আই. ডি. সিলেক্ট করুন")]
        public int? EntryId { get; set; }
        [ForeignKey("EntryId")]
        public virtual Entry Entry { get; set; }
    }
}
