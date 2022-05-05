using EMY.ECommerceSystem.Core.Domain.Entities.Common;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    public class UserAdress : BaseEntity
    {
        public Guid UserAdressID { get; set; }
        public Guid UserID { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AdressType { get; set; }
    }
}
