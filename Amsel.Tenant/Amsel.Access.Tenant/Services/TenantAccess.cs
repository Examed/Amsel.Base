using Amsel.Framework.Structure.Factory;
using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Services;
using Amsel.Framework.Utilities.Extensions.Http;
using Amsel.Model.Tenant.TenantModels;
using Amsel.Resources.Authentication.Endpoints;
using Amsel.Resources.Tenant.Controller;
using JetBrains.Annotations;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amsel.Access.Tenant.Services
{
    public class TenantAccess : CRUDAccess<TenantEntity>
    {
        /// <inheritdoc/>
        protected override string Endpoint => AuthEndpointResources.ENDPOINT;

        protected override bool RequestLocal => false;

        /// <inheritdoc/>
        protected override string Resource => AuthEndpointResources.TENANT;

        [NotNull] private UriBuilder TenantGet => UriBuilderFactory.GetAPIBuilder(Endpoint, Resource, TenantControllerResources.GET, RequestLocal);

        public TenantAccess(IAuthenticationService authenticationService) : base(authenticationService) { }

        #region PUBLIC METHODES
        public async Task<TenantEntity> GetTenantAsync(Guid id)
        {
            HttpResponseMessage response = await GetAsync(TenantGet, (nameof(id), id)).ConfigureAwait(false);
            return await response.DeserializeElseThrowAsync<TenantEntity>().ConfigureAwait(false);
        }

        [NotNull]
        public async Task<TenantEntity> GetTenantByNameAsync(string name)
        {
            HttpResponseMessage response = await GetAsync(TenantGet, (nameof(name), name)).ConfigureAwait(false);
            return await response.DeserializeElseThrowAsync<TenantEntity>().ConfigureAwait(false);
        }
        #endregion
    }
}