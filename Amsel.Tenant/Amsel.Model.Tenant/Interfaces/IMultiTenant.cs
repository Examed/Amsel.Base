using Amsel.Model.Tenant.TenantModels;

namespace Amsel.Model.Tenant.Interfaces
{
    public interface IMultiTenant
    {
        TenantEntity Tenant { get; set; }
    }
}