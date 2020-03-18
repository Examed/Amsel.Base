using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Amsel.Model.Tenant.TenantModels
{
    public class TenantEntity 
    {
        [Key]
        public Guid Id { get; protected set; }

        public bool Admin { get; protected set; }

        public string TenantName { get; set; }


        #region  CONSTRUCTORS

        [JsonConstructor]
        public TenantEntity(Guid id, string tenantName)
        {
            Id = id;
            TenantName = tenantName ?? throw new ArgumentNullException(nameof(tenantName));
        }

        public TenantEntity(string tenantName) => TenantName =
            tenantName ?? throw new ArgumentNullException(nameof(tenantName));

        protected TenantEntity()
        {
        }
        #endregion
    }
}