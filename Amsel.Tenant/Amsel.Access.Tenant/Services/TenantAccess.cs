using Amsel.Framework.Structure.Interfaces;
using Amsel.Framework.Structure.Models.Address;
using Amsel.Framework.Utilities.Extensions.Http;
using Amsel.Model.Tenant.TenantModels;
using Amsel.Resources.Authentication.Endpoints;
using Amsel.Resources.Tenant.Controller;
using JetBrains.Annotations;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amsel.Access.Authentication.Services
{
    public class TenantAccess : CRUDAccess<TenantEntity>
    {
        #region  CONSTRUCTORS

        public TenantAccess(IAuthenticationService authenticationService) : base(authenticationService) { }

        #region PUBLIC METHODES
        #endregion


        public async Task<Guid?> GetIdByNameAsync(string name)
        {
            TenantEntity tenant = await GetTenantByNameAsync(name).ConfigureAwait(false);
            return tenant.Id;
        }

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