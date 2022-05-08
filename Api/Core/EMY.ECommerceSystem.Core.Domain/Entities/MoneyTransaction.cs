using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using EMY.ECommerceSystem.Core.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblMoneyTransactions", Schema = "shopping")]
    public class MoneyTransaction : BaseEntity
    {
        [Key]
        public Guid MoneyTransactionID { get; set; }
        public Guid UserID { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public decimal Value { get; set; }
        [MaxLength(10), MinLength(3)] //BTC,ETH,USDT... USD,EUR,MXN,TRY...
        public string Currency { get; set; }
        [ForeignKey("UserID")] public virtual User User { get; set; }

    }
}
