using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblOrders", Schema = "shopping")]
    public class Order : BaseEntity
    {
        [Key]
        public Guid OrderID { get; set; }
        public Guid UserID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }
        public decimal? Total { get; set; }
        public Guid MoneyTransactionID { get; set; }
        [ForeignKey("MoneyTransactionID")] public virtual MoneyTransaction Transaction { get; set; }
        [ForeignKey("UserID")] public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
