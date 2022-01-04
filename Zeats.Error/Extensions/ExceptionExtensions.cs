using System;

namespace Zeats.Error.Extensions
{
    public static class ExceptionExtensions
    {
        public static ErrorInfo ToErrorInfo(this Exception exception)
        {
            return new ErrorInfo
            {
                Severity = Severity.Error,
                Type = "Generic",
                Message = exception.Message,
                Details = exception.ToString()
            };
        }
    }
}