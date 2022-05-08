using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblBaskets", Schema = "shopping")]
    public class Basket : BaseEntity
    {
        [Key]
        public Guid BasketID { get; set; }
        public Guid UserID { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid? MoneyTransactionID { get; set; }
       [ForeignKey("MoneyTransactionID")] public MoneyTransaction Transaction { get; set; }
        public bool IsActive { get; set; }
    }
}
