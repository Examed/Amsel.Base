using Amsel.Access.Authentication.Services;
using Autofac;

namespace Amsel.Access.Authentication.Bootstrap
{
    /// <inheritdoc/>
    public class TenantAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TenantAccess>();
            base.Load(builder);
        }
    }
}