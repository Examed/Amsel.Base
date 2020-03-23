using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Amsel.Model.Tenant.TenantModels
{
    public class TenantEntity
    {
        protected TenantEntity() { }

        public TenantEntity(string tenantName) => TenantName = tenantName ?? throw new ArgumentNullException(nameof(tenantName));


        [JsonConstructor]
        public TenantEntity(Guid id, string tenantName)
        {
            Id = id;
            TenantName = tenantName ?? throw new ArgumentNullException(nameof(tenantName));
        }

        public bool Admin { get; set; }

        [Key]
        public Guid Id { get; protected set; }

        public string TenantName { get; set; }
    }
}