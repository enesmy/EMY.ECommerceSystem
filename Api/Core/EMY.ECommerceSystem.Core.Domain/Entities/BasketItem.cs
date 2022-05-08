using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblBasketItems", Schema = "shopping")]
    public class BasketItem : BaseEntity
    {
        [Key]
        public Guid BasketItemID { get; set; }
        public Guid ProductID { get; set; }
        public Guid BasketID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("ProductID")]public virtual Product Product { get; set; }
        [ForeignKey("BasketID")] public virtual Basket Basket { get; set; }
    }
}