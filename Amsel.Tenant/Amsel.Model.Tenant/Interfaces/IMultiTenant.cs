using Amsel.Framework.Base.Interfaces;
using Amsel.Model.Tenant.TenantModels;
using System;

namespace Amsel.Model.Tenant.Interfaces {
    public interface ITenantEntity : IEntity
    {
        TenantEntity Tenant { get; set; }
        Guid? TenantId { get; set; }
    }
}