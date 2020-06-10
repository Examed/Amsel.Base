
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amsel.Model.Logging.LogMessageModels {
    [ComplexType]
    public class LogMessage
    {
        public LogMessage()
        {
        }

        public LogMessage(LogLevel level, string logger, string message, string type, string exception = null)
        {
            Exception = exception;
            Level = level;
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public string Exception { get; set; }
        [Key]
        public int Id { get; set; }
        public LogLevel Level { get; set; }
        // Distinct
        public string Logger { get; set; }
        // Distinct  
        public string Message { get; set; }
    }
}

