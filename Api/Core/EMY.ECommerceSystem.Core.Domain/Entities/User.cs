using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using EMY.ECommerceSystem.Core.Domain.Enums.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    public class User : BaseEntity
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public Guid DefaultAdressID { get; set; }
        [ForeignKey("DefaultAdressID")] public virtual UserAdress DefaultAdress { get; set; }
        public string UserType { get; set; }
        [DefaultValue(0)]
        public UserStatus UserStatus { get; set; }
        public Guid UserGroupID { get; set; }
        public UserGroup Group { get; set; }
        public string UserImage { get; set; }
        public string UserToken { get; set; }
        public decimal UserBalance { get; set; }


        public string PasswordStored { get; set; }

        [NotMapped]
        public string Password
        {
            set { PasswordStored = SystemCryptography.Encrypt(value); }
        }

        public bool PasswordControl(string password)
        {
            string pswhash = SystemCryptography.Encrypt(password);
            return (pswhash == PasswordStored);
        }
      

    }
}
