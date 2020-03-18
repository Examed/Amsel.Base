using Amsel.Framework.Base.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amsel.DTO.Logging
{


    public class LogMessageDTO : GuidEntity
    {
        public LogLevel Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string CallerMemberName { get; set; }
    }

    public class LogOccurrenceDTO : GuidEntity
    {
        public DateTime Time { get; set; } = DateTime.UtcNow;
        public string Tenant { get; set; }
        public string Properties { get; set; }
        public LogMessageDTO Message { get; set; }
        public string StackTrace { get; set; }
    }
}
