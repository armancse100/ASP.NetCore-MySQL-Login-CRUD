using System;

namespace InventoryManagement.Models
{
    public class Entry
    {
        public int Id { get; set; }

        public DateTime EntryDate { get; set; }
        public int InitialCount { get; set; }
        public string NameOfSupplier { get; set; }
        public string AddressOfSupplier { get; set; }
        public string DescriptionOfProduct { get; set; }
        public int NumberOfSuppliedProduct { get; set; }
        public int SuppliedProductUnitPrice { get; set; }
        public int SuppliedProductTotalPrice { get; set; }
        public int TotalNoOfProductAfterInserted { get; set; }

        public DateTime ReceiveDate { get; set; }
        public string NameOfUser { get; set; }
        public string AddressOfUser { get; set; }
        public string DemandnoteNo { get; set; }
        public int NumberOfReceivedProduct { get; set; }
        public int TotalNoOfProductAfterdeduction { get; set; }
    }
}
