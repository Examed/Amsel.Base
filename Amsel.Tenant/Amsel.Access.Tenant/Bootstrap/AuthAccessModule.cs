using Amsel.Access.Tenant.Services;
using Autofac;

namespace Amsel.Access.Tenant.Bootstrap {
    /// <inheritdoc/>
    public class TenantAccessModule : Module
    {
        #region protected methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TenantAccess>();
            base.Load(builder);
        }
        #endregion
    }
}