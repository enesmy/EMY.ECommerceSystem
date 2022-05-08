using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblUserAdresses", Schema = "profile")]
    public class UserAdress : BaseEntity
    {
        [Key]
        public Guid UserAdressID { get; set; }
        public Guid UserID { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AdressType { get; set; }
       [ForeignKey("UserID")] public virtual User User { get; set; }
    }
}
