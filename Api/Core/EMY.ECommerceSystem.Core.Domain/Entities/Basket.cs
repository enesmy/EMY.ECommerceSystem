using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    public class Basket : BaseEntity
    {
        [Key]
        public Guid BasketID { get; set; }
        public Guid UserID { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
