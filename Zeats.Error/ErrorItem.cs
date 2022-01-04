namespace Zeats.Error;

public class ErrorItem
{
    public Severity Severity { get; set; }
    public string Type { get; set; }
    public string Property { get; set; }
    public string Message { get; set; }
    public string Details { get; set; }
}