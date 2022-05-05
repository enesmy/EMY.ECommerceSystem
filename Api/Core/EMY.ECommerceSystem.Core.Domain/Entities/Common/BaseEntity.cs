using System.ComponentModel.DataAnnotations;

namespace EMY.ECommerceSystem.Core.Domain.Entities.Common
{
    public class BaseEntity
    {
        [Required]
        public Guid CreatorID { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public Guid LastUpdaterID { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public Guid? DeleterID { get; set; }
    }
}
