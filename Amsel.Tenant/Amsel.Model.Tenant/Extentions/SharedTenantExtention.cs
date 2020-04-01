using System;
using System.Collections.Generic;
using System.Text;
using Amsel.Model.Tenant.TenantModels;
using Amsel.Model.Tenant.Interfaces;

namespace Amsel.Model.Tenant.Extentions
{
    public static class SharedTenantExtention
    {
        public static bool IsUsable(this ISharedTenant sharedTenant,TenantEntity tenant)
        {
            return sharedTenant.IsUsable(tenant.TenantName);
        }

        public static bool IsUsable(this ISharedTenant sharedTenant, TenantName tenantName)
        {
            return sharedTenant.IsUsable(tenantName.ToString());
        }

        public static bool IsUsable(this ISharedTenant sharedTenant, string tenantName)
        {
            if (tenantName.Equals(sharedTenant.Tenant?.TenantName))
                return true;
            if (sharedTenant.IsPublic)
                return true;

            return false;
        }
        public static bool IsEdible(this ISharedTenant sharedTenant, TenantEntity tenant)
        {
            return sharedTenant.IsEdible(tenant.TenantName);
        }

        public static bool IsEdible(this ISharedTenant sharedTenant, TenantName tenantName)
        {
            return sharedTenant.IsEdible(tenantName.ToString());
        }
        public static bool IsEdible(this ISharedTenant sharedTenant, string tenantName)
        {
            if (tenantName.Equals(sharedTenant.Tenant?.TenantName))
                return true;
            return false;
        }
    }
}
