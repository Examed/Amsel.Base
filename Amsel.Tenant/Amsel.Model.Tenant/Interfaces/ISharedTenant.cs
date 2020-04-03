namespace Amsel.Model.Tenant.Interfaces
{
    public interface ISharedTenant : ITenantEntity
    {
        bool IsPublic { get; set; }

    }
}