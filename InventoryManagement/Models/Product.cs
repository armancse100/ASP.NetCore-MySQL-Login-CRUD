using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        [Required]
        public string Name { get; set; }
        [Column("CurrentStoreValue"), Required]
        public int CurrentStoreValue { get; set; }

        [Column("ProductCategoryId"), Required]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategoryName { get; set; }

        [Column("ProductTypeId"), Required]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public virtual ProductType ProductTypeName { get; set; }

        public Product()
        {
            CreateTime = DateTime.UtcNow;
        }
    }
}
