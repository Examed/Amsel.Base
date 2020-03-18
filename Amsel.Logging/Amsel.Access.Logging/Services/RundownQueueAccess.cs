using Amsel.Access.Authentication.Services;
using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Models;
using Amsel.Model.Logging.LogMessageModels;
using Amsel.Model.Logging.LogOccurrenceModels;
using Amsel.Resources.Logging.Endpoints;

namespace Amsel.Access.Rundown.Services
{

    public class LogMessageAccess : CRUDAccess<LogMessage>
    {
        /// <inheritdoc/>
        protected override string Endpoint => LoggingEndpointResources.ENDPOINT;
        /// <inheritdoc/>
        protected override string Resource => LoggingEndpointResources.MESSAGE;

        protected override bool RequestLocal => true;

        public LogMessageAccess(ISecretAuthenticationService authenticationService, TenantName tenant) : base(tenant, authenticationService) { }
        public LogMessageAccess(ISecretAuthenticationService authenticationService) : base(authenticationService) { }   
    }

    public class LogOccurrenceAccess : CRUDAccess<LogOccurrence>
    {
        /// <inheritdoc/>
        protected override string Endpoint => LoggingEndpointResources.ENDPOINT;
        /// <inheritdoc/>
        protected override string Resource => LoggingEndpointResources.OCCURRENCE;

        protected override bool RequestLocal =>true;

        public LogOccurrenceAccess(ISecretAuthenticationService authenticationService, TenantName tenant) : base(tenant, authenticationService) { }
        public LogOccurrenceAccess(ISecretAuthenticationService authenticationService) : base(authenticationService) { }
    }
}