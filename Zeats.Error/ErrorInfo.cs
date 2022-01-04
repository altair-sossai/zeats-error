using System.Collections.Generic;

namespace Zeats.Error;

public class ErrorInfo : ErrorItem
{
    public List<ErrorItem> Errors { get; set; }
}