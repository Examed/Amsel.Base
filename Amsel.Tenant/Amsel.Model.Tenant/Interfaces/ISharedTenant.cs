using Amsel.Model.Tenant.TenantModels;
using System.Collections.Generic;

namespace Amsel.Model.Tenant.Interfaces
{
    public interface ISharedTenant : ITenantEntity
    {
        bool IsPublic { get; set; }

    }
}