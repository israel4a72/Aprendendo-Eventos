using Events.EventsSourcing;
using Events.EventsSourcing.Services;
using Microsoft.AspNetCore.Mvc;

namespace Events.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly EventPublisherService _eventPublisherService;

    public EventsController(EventPublisherService eventPublisherService)
    {
        _eventPublisherService = eventPublisherService;
    }
    
    [HttpGet]
    [Route("first-test")]
    public IActionResult TestEvents([FromServices]FirstConsumerService firstConsumerService)
    {
        _eventPublisherService.ExecuteFirstSomething();
        return Ok();
    }
    [HttpGet]
    [Route("second-test")]
    public IActionResult TestEvents2([FromServices]SecondConsumerService secondConsumerService)
    {
        _eventPublisherService.ExecuteSecondSomething();
        return Ok();
    }
}