﻿using EMY.ECommerceSystem.Core.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    [Table("tblRoles", Schema = "authorize")]
    public class Role : BaseEntity
    {
        [Key]
        public Guid RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}