using Amsel.Access.Logging.Services;
using Autofac;

namespace Amsel.Access.Logging.Bootstrap
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