using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblRoles")]
    public class Role : BaseEntity
    {
        public Guid RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}