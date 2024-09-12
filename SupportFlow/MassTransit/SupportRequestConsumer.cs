using MassTransit;
using SupportFlow.ChainOfResponsibility;

namespace SupportFlow.MassTransit;

public class SupportRequestConsumer : IConsumer<SupportRequest>
{
    private readonly ISupportRequestHandler _handler;

    public SupportRequestConsumer(ISupportRequestHandler handler)
    {
        _handler = handler;
    }

    public async Task Consume(ConsumeContext<SupportRequest> context)
    {
        await _handler.Handle(context.Message);
    }
}