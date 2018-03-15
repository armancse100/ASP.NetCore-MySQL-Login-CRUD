using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("ProductType")]
    public class ProductType
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        [Column("Name"), Required]
        public string Name { get; set; }

        public ProductType()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
