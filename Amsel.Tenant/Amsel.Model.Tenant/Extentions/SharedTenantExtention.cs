using Amsel.Model.Tenant.Interfaces;
using Amsel.Model.Tenant.TenantModels;

namespace Amsel.Model.Tenant.Extentions {
    public static class SharedTenantExtention
    {
        public static bool IsEdible(this ISharedTenant sharedTenant, TenantEntity tenant) => sharedTenant.IsEdible(tenant.Name);

        public static bool IsEdible(this ISharedTenant sharedTenant, TenantName tenantName) => sharedTenant.IsEdible(tenantName.ToString());

        public static bool IsEdible(this ISharedTenant sharedTenant, string tenantName) {
            if(tenantName.Equals(sharedTenant.Tenant?.Name)) {
                return true;
            }

            return false;
        }

        public static bool IsUsable(this ISharedTenant sharedTenant, TenantEntity tenant) => sharedTenant.IsUsable(tenant.Name);

        public static bool IsUsable(this ISharedTenant sharedTenant, TenantName tenantName) => sharedTenant.IsUsable(tenantName.ToString());

        public static bool IsUsable(this ISharedTenant sharedTenant, string tenantName) {
            if(tenantName.Equals(sharedTenant.Tenant?.Name)) {
                return true;
            }

            if(sharedTenant.IsPublic) {
                return true;
            }

            return false;
        }
    }
}
