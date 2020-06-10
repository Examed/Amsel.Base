using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Amsel.Model.Tenant.TenantModels {
    public class TenantEntity
    {
        protected TenantEntity()
        {
        }
        public TenantEntity(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));
        [JsonConstructor]
        public TenantEntity(Guid id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public bool Admin { get; set; }
        [Key]
        public Guid Id { get; protected set; }
        public string Name { get; set; }
    }
}