using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;

namespace Together.Api.Controllers;
[ApiController]
[Route("api")]
public class EventController:ControllerBase
{
    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        AddEventResponse response = new AddEventResponse(
            Guid.NewGuid(),
            request.name,
            request.coordinator,
            request.place,
            request.lat,
            request.lng,
            request.fee
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