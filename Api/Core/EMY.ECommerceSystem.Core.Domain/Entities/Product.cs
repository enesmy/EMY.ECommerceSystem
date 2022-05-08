using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblProducts", Schema = "product")]
    public class Product : BaseEntity
    {
        [Key]
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryID { get; set; }
        [ForeignKey("CategoryID")] public virtual Category Category { get; set; }

    }
}
