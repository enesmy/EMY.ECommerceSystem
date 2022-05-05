namespace EMY.ECommerceSystem.Core.Domain.Entities
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserGroupRole> Roles { get; set; }
        public bool IsActive { get; set; }
    }
}