using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using EMY.ECommerceSystem.Core.Domain.Enums.Entities;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    public class UserGroupRole : BaseEntity
    {
        public Guid UserGrpoupRoleID { get; set; }
        public Guid UserGroupID { get; set; }
        public Guid RoleID { get; set; }
        public AuthDegree AuthDegree { get; set; }
        public virtual UserGroup UserGroup { get; set; }
        public virtual Role Role { get; set; }

    }
}
