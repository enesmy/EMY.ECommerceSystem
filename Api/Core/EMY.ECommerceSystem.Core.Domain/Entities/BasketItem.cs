using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    public class BasketItem : BaseEntity
    {
        [Key]
        public Guid BasketItemID { get; set; }
        public Guid ProductId { get; set; }
        public Guid BasketId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
    }
}