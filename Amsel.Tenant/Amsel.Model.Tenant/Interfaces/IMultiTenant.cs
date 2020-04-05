
using Amsel.Model.Tenant.TenantModels;
using Amsel.Models.Rundown.Models;
using System;

namespace Amsel.Model.Tenant.Interfaces
{
    public interface ITenantEntity: IEntity
    {
        Guid TenantId { get; set; }
        TenantEntity Tenant { get; set; }
    }
}