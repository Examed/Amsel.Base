using Amsel.Framework.Database.SQL.Interfaces;
using Amsel.Framework.Database.SQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amsel.Endpoint.Logging.Models
{
    [Owned,ComplexType]
    public class LogOccurrence : IMultiTenant
    {
        [Key]
        public int Id { get;set;}
        public string Properties { get; set; }
        public string StackTrace { get; set; }
        public DateTime Time { get; set; }
        public Tenant Tenant { get; set; }
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


