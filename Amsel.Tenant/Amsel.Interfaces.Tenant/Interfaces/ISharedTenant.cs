using Amsel.Framework.Database.SQL.Models;
using System.Collections.Generic;

namespace Amsel.Framework.Database.SQL.Interfaces
{
    public interface ISharedTenant : IMultiTenant
    {
        bool IsPublic { get; set; }

        bool IsSystem { get; set; }

        ICollection<Tenant> UsedBy { get; set; }
    }
}