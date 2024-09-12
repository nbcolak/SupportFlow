namespace SupportFlow.ChainOfResponsibility;

public interface ISupportRequestHandler
{
    void SetNext(ISupportRequestHandler nextHandler);
    Task Handle(SupportRequest request);
}