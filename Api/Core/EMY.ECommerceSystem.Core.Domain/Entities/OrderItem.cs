using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblOrderItems", Schema = "shopping")]
    public class OrderItem : BaseEntity
    {
        [Key]
        public Guid OrderItemID { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Guid ProductID { get; set; }
        public Guid OrderID { get; set; }
        [ForeignKey("ProductID")] public virtual Product Product { get; set; }
        [ForeignKey("OrderID")] public virtual Order Order { get; set; }

    }
}