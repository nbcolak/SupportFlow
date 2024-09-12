namespace SupportFlow.ChainOfResponsibility;

public class SupportRequest
{
    public string RequestId { get; set; }
    public SupportCategory Category { get; set; }
    public string Description { get; set; }
}