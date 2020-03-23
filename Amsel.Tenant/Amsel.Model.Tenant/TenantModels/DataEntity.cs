using Amsel.Framework.Base.Interfaces;
using Amsel.Model.Tenant.Interfaces;
using System;

namespace Amsel.Model.Tenant.TenantModels
{
    public abstract class DataEntity : IGuidEntity, ITenantEntity, INamedEntity
    {
        protected DataEntity()
        {
            Type = GetType().FullName;
            Name = GetType().Name;
        }


        public abstract object GetData();

        public bool GlobalAccess { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }


        public TenantEntity Tenant { get; set; }

        public string Type { get; set; }
    }
}