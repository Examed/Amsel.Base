using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Amsel.Framework.Database.SQL.Models
{
    public class Tenant 
    {
        [Key]
        public Guid Id { get; protected set; }

        public bool Admin { get; protected set; }
      
        public string TenantName { get;  set; }


        #region  CONSTRUCTORS

        [JsonConstructor]
        public Tenant(Guid id, string tenantName)
        {
            Id = id;
            TenantName = tenantName ?? throw new ArgumentNullException(nameof(tenantName));
        }

        public Tenant(string tenantName) => TenantName =
            tenantName ?? throw new ArgumentNullException(nameof(tenantName));

        protected Tenant()
        {
        }
        #endregion
    }
}