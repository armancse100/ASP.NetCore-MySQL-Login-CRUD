using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        [Column("Name"), Required]
        public string Name { get; set; }

        public ProductCategory()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
