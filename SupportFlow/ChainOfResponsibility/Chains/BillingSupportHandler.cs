namespace SupportFlow.ChainOfResponsibility;

public class BillingSupportHandler : ISupportRequestHandler
{
    private ISupportRequestHandler _nextHandler;

    public void SetNext(ISupportRequestHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public async Task Handle(SupportRequest request)
    {
        Console.WriteLine("Billing support is being provided...");

        if (_nextHandler != null)
        {
            await _nextHandler.Handle(request);
        }
    }
}
