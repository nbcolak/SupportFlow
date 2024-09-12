using Microsoft.AspNetCore.Mvc;
using SupportFlow.ChainOfResponsibility;

namespace SupportFlow.Controllers;
[ApiController]
[Route("api/[controller]")]
public class SupportController : ControllerBase
{
    private readonly ISupportRequestHandler _supportHandler;

    public SupportController(ISupportRequestHandler supportHandler)
    {
        _supportHandler = supportHandler;
    }

    [HttpPost("submit-request")]
    public async Task<IActionResult> SubmitRequest([FromBody] SupportRequest request)
    {
        await _supportHandler.Handle(request);
        return Ok("Support request has been successfully processed.");
    }
}