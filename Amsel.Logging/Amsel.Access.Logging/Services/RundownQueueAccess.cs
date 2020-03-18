using Amsel.Access.Authentication.Services;
using Amsel.Endpoint.Logging.Models;
using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Models;
using Amsel.Resources.Rundown.Endpoints;
using System;

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