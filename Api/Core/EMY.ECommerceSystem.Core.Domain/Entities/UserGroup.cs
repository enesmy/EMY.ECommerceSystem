using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblUserGroups", Schema = "authorize")]
    public class UserGroup:BaseEntity
    {
        [Key]
        public Guid UserGroupID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserGroupRole> Roles { get; set; }
        public bool IsActive { get; set; }
    }
}