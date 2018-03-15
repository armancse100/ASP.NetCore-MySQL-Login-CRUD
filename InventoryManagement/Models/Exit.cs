using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    public class Exit
    {
        public int Id { get; set; }

        [Column("CreateTime")]
        public DateTime CreateTime { get;}

        [Column("ReceiveDate"), Required]
        public DateTime ReceiveDate { get; set; }
        [Column("NameOfUser"), Required]
        public string NameOfUser { get; set; }
        [Column("AddressOfUser"), Required]
        public string AddressOfUser { get; set; }
        [Column("DemandnoteNo"), Required]
        public string DemandnoteNo { get; set; }
        [Column("NumberOfReceivedProduct"), Required]
        public int NumberOfReceivedProduct { get; set; }
        [Column("TotalNoOfProductAfterdeduction"), Required]
        public int TotalNoOfProductAfterdeduction { get; set; }

        [Column("ProductId"), Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual ProductCategory ProductName { get; set; }

        [Column("EntryId"), Required]
        public int EntryId { get; set; }
        [ForeignKey("EntryId")]
        public virtual Entry Entry { get; set; }

        public Exit()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
