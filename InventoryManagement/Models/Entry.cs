using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Entry")]
    public class Entry
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime? CreateTime { get; set; }
        [Column("EntryDate"), Required]
        public DateTime EntryDate { get; set; }
        [Column("InitialCount"), Required]
        public int InitialCount { get; set; }
        [Column("NameOfSupplier"), Required]
        public string NameOfSupplier { get; set; }
        [Column("AddressOfSupplier"), Required]
        public string AddressOfSupplier { get; set; }

        [Column("ProductId"), Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product ProductName { get; set; }

        [Column("DescriptionOfProduct"), Required]
        public string DescriptionOfProduct { get; set; }
        [Column("NumberOfSuppliedProduct"), Required]
        public int NumberOfSuppliedProduct { get; set; }
        [Column("SuppliedProductUnitPrice"), Required]
        public int SuppliedProductUnitPrice { get; set; }
        [Column("SuppliedProductTotalPrice"), Required]
        public int SuppliedProductTotalPrice { get; set; }
        [Column("TotalNoOfProductAfterInserted"), Required]
        public int TotalNoOfProductAfterInserted { get; set; }

        public Entry()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
