using System;

namespace Amsel.Model.Tenant.TenantModels {
    public class TenantName
    {
        private string _name;

        public TenantName(string name) => _name = name;

        public static implicit operator TenantName(string name) {
            // While not technically a requirement; see below why this is done.
            if(name == null)
            {
                return null;
            }

            return new TenantName(name);
        }

        #region public methods
        public override string ToString() => _name;
        #endregion
    }
}
