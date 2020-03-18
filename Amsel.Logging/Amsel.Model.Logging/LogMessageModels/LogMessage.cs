using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Amsel.Endpoint.Logging.Models
{
    [ComplexType]
    public class LogMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Exception { get; set; }

        public LogLevel Level { get; set; }

        public string Logger { get; set; }

        public string Message { get; set; }

        public ICollection<LogOccurrence> Occurences { get; set; } = new List<LogOccurrence>();

        public LogMessage() { }

        public LogMessage(LogLevel level, string logger, string message, string type, string exception = null)
        {

            Exception = exception;
            Level = level;
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
    }
}


