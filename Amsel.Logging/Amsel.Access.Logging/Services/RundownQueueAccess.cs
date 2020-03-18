using Amsel.Access.Authentication.Services;
using Amsel.DTO.Logging;
using Amsel.Framework.Base.DTO;
using Amsel.Framework.Structure.Blazor.Authorize;
using Amsel.Framework.Structure.Client.Service;
using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Models;
using Amsel.Framework.Structure.Models.Address;
using Amsel.Framework.Utilities.Extensions.Http;
using Amsel.Resources.Rundown.Endpoints;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amsel.Access.Rundown.Services
{

    public class LogMessageAccess : CRUDAccess<LogMessageDTO>
    {
        /// <inheritdoc/>
        protected override string Endpoint => LoggingEndpointResources.ENDPOINT;
        /// <inheritdoc/>
        protected override string Resource => LoggingEndpointResources.MESSAGE;

        protected override bool RequestLocal => true;

        public LogMessageAccess(ISecretAuthenticationService authenticationService, TenantName tenant) : base(tenant, authenticationService) { }
        public LogMessageAccess(ISecretAuthenticationService authenticationService) : base(authenticationService) { }   
    }

    public class LogOccurrenceAccess : CRUDAccess<LogOccurrenceDTO>
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