using Amsel.Model.Logging.LogMessageModels;
using Amsel.Model.Tenant.Interfaces;
using Amsel.Model.Tenant.TenantModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amsel.Model.Logging.LogOccurrenceModels
{
    [Owned,ComplexType]
    public class LogOccurrence : IMultiTenant
    {
        [Key]
        public int Id { get;set;}
        public string Properties { get; set; }
        public string StackTrace { get; set; }
        public DateTime Time { get; set; }
        public TenantEntity Tenant { get; set; }
        public LogMessage Message { get; set; }

        public LogOccurrence() { }
        public LogOccurrence(LogMessage message, string properties, string stackTrace)
        {
            Message = message;
            Properties = properties ?? throw new ArgumentNullException(nameof(properties));
            StackTrace = stackTrace;
            Time = DateTime.UtcNow;
        }
    }
}


