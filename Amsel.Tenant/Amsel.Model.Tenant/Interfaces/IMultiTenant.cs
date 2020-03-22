using Amsel.Model.Tenant.TenantModels;

namespace Amsel.Model.Tenant.Interfaces
{
    public interface ITenantEntity
    {
        TenantEntity Tenant { get; set; }
    }
}