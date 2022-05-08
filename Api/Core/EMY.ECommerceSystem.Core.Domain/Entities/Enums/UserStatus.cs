namespace EMY.ECommerceSystem.Core.Domain.Entities.Enums
{
    public enum UserStatus
    {
        Active = 0,
        PendingDeletion = 1,
        PendingActivation = 2,
        PendingActivationPermanently = 3,
        PendingActivationTemporary = 4
    }
}
