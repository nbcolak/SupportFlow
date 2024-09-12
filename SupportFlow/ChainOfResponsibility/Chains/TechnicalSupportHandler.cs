namespace SupportFlow.ChainOfResponsibility;

public class TechnicalSupportHandler : ISupportRequestHandler
{
    private ISupportRequestHandler _nextHandler;

    public void SetNext(ISupportRequestHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public async Task Handle(SupportRequest request)
    {
        Console.WriteLine("Technical support is being provided...");

        if (_nextHandler != null)
        {
            await _nextHandler.Handle(request);
        }
    }
}
