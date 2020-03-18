using Amsel.Framework.Database.SQL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Amsel.Framework.Database.SQL.Interfaces
{
    public interface INameEntity
    {  
        string Name { get; set; }
    }

    public interface IMultiTenant
    {
        Tenant Tenant { get; set; }
    }
}