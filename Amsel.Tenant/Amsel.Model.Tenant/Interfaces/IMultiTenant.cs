
using Amsel.Model.Tenant.TenantModels;
using Amsel.Models.Rundown.Models;

namespace Amsel.Model.Tenant.Interfaces
{
    public interface ITenantEntity: IEntity
    {
        TenantEntity Tenant { get; set; }
    }
}