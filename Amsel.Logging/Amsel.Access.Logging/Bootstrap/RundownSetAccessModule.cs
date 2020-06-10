using Amsel.Access.Logging.Services;
using Autofac;

namespace Amsel.Access.Logging.Bootstrap {
    /// <inheritdoc/>
    public class LoggingAccessModule : Module
    {
        #region protected methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LogOccurrenceAccess>();
            builder.RegisterType<LogMessageAccess>();

            base.Load(builder);
        }
        #endregion
    }
}