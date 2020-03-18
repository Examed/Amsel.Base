using Amsel.Framework.Database.SQL.Models;
using Amsel.Framework.Structure.Blazor.Authorize;
using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Models.Address;
using Amsel.Framework.Utilities.Extensions.Http;
using Amsel.Resources.Authentication.Controller;
using Amsel.Resources.Authentication.Endpoints;
using JetBrains.Annotations;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amsel.Access.Authentication.Services
{
    public class TenantAccess : CRUDAccess<Tenant>
    {
        #region  CONSTRUCTORS

        public TenantAccess(IAuthenticationService authenticationService) : base(authenticationService) { }

        #region PUBLIC METHODES
        #endregion


        public async Task<Guid?> GetIdByNameAsync(string name)
        {
            Tenant tenant = await GetTenantByNameAsync(name).ConfigureAwait(false);
            return tenant.Id;
        }

        public async Task<Tenant> GetTenantAsync(Guid id)
        {
            HttpResponseMessage response = await GetAsync(TenantGet, (nameof(id), id)).ConfigureAwait(false);
            return await response.DeserializeElseThrowAsync<Tenant>().ConfigureAwait(false);
        }

        [NotNull]
        public async Task<Tenant> GetTenantByNameAsync(string name)
        {
            HttpResponseMessage response = await GetAsync(TenantGet, (nameof(name), name)).ConfigureAwait(false);
            return await response.DeserializeElseThrowAsync<Tenant>().ConfigureAwait(false);
        }
        #endregion

        #region STATICS, CONST and FIELDS

        /// <inheritdoc/>
        protected override string Endpoint => AuthEndpointResources.ENDPOINT;

        /// <inheritdoc/>
        protected override string Resource => AuthEndpointResources.TENANT;

        [NotNull] private UriBuilder TenantGet => UriBuilderFactory.GetAPIBuilder(Endpoint, Resource, TenantControllerResources.GET, RequestLocal);

        protected override bool RequestLocal => false;
        #endregion
    }
}