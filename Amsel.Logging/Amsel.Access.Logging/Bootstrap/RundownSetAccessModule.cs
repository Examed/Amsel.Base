using Amsel.Access.Rundown.Services;
using Autofac;

namespace Amsel.Access.Rundown.Bootstrap
{
    /// <inheritdoc/>
    public class LoggingAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LogOccurrenceAccess>();
            builder.RegisterType<LogMessageAccess>();

            base.Load(builder);
        }
    }
}