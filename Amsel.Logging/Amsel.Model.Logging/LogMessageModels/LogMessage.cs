using Amsel.Model.Logging.LogOccurrenceModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amsel.Model.Logging.LogMessageModels
{
    [ComplexType]
    public class LogMessage
    {
        [Key]
        public int Id { get; set; }

        public string Exception { get; set; }

        public LogLevel Level { get; set; }

        public string Logger { get; set; }

        public string Message { get; set; }



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


