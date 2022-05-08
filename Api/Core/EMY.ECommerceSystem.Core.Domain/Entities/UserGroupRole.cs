using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using EMY.ECommerceSystem.Core.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblUserGroupRoles", Schema = "authorize")]
    public class UserGroupRole : BaseEntity
    {
        [Key]
        public Guid UserGrpoupRoleID { get; set; }
        public Guid UserGroupID { get; set; }
        public Guid RoleID { get; set; }
        public AuthDegree AuthDegree { get; set; }
        [ForeignKey("UserGroupID")] public virtual UserGroup UserGroup { get; set; }
        [ForeignKey("RoleID")] public virtual Role Role { get; set; }

    }
}
