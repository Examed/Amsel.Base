using Amsel.Framework.Base.Interfaces;
using Amsel.Model.Tenant.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amsel.Model.Tenant.TenantModels {
    public abstract class DataEntity : IGuidEntity, ITenantEntity, INamedEntity
    {
        protected DataEntity()
        {
            Type = GetType().FullName;
            Name = GetType().Name;
        }

        public bool GlobalAccess { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(TenantId))]
        public virtual TenantEntity Tenant { get; set; }
        public Guid? TenantId { get; set; }
        public string Type { get; set; }

        #region public methods
        public abstract object GetData();
        #endregion
    }
}