using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;
using Together.Appliction.Services;
namespace Together.Api.Controllers;
[ApiController]
[Route("api")]
public class EventController:ControllerBase
{
    private readonly IEventService eventService;
    public EventController(IEventService eventService)
    {
        this.eventService = eventService;
    }
    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        var result = this.eventService.add(request.name,request.coordinator,request.place,request.lat,request.lng,request.fee);
        AddEventResponse response = new AddEventResponse(
            result.id,
            result.name,
            result.coordinator,
            result.place,
            result.lat,
            result.lng,
            result.fee
        );
        return Ok(response);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        QueryEventResponse response = new QueryEventResponse("name","Nick","Taipei",120.2f,23.5f,100);
        QueryEventResponse[] events = new QueryEventResponse[]{response,response,response};
        return Ok(events);
    }
}