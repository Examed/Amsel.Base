using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Services;
using Amsel.Model.Logging.LogMessageModels;
using Amsel.Model.Logging.LogOccurrenceModels;
using Amsel.Model.Tenant.TenantModels;
using Amsel.Resources.Logging.Endpoints;

namespace Amsel.Access.Logging.Services
{
    public class LogMessageAccess : CRUDAccess<LogMessage>
    {
        /// <inheritdoc/>
        protected override string Endpoint => LoggingEndpointResources.ENDPOINT;

        protected override bool RequestLocal => true;

        /// <inheritdoc/>
        protected override string Resource => LoggingEndpointResources.MESSAGE;

        public LogMessageAccess(ISecretAuthenticationService authenticationService) : base(authenticationService) { }
        public LogMessageAccess(ISecretAuthenticationService authenticationService, TenantName tenant) : base(tenant, authenticationService)
        { }
    }

    public class LogOccurrenceAccess : CRUDAccess<LogOccurrence>
    {
        /// <inheritdoc/>
        protected override string Endpoint => LoggingEndpointResources.ENDPOINT;

        protected override bool RequestLocal => true;

        /// <inheritdoc/>
        protected override string Resource => LoggingEndpointResources.OCCURRENCE;

        public LogOccurrenceAccess(ISecretAuthenticationService authenticationService) : base(authenticationService) { }
        public LogOccurrenceAccess(ISecretAuthenticationService authenticationService, TenantName tenant) : base(tenant, authenticationService)
        { }
    }
}