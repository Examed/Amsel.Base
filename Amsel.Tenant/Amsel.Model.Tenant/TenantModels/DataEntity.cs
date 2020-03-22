using Amsel.Framework.Base.Interfaces;
using Amsel.Model.Tenant.Interfaces;
using System;

namespace Amsel.Model.Tenant.TenantModels
{
    public abstract class DataEntity : IGuidEntity, ITenantEntity, INamedEntity
    {
        public Guid Id { get; set; }
        public bool GlobalAccess { get; set; }

        public string Name { get; set; }

        #region ITenantEntity Members

        public TenantEntity Tenant { get; set; }
        #endregion

        public string Type { get; set; }

        #region  CONSTRUCTORS

        protected DataEntity()
        {
            Type = GetType().FullName;
            Name = GetType().Name;
        }
        #endregion

        #region PUBLIC METHODES

        public abstract object GetData();
        #endregion
    }
}