namespace Together.Appliction.Services;

public class EventService : IEventService
{
    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        return new EventAddResult(Guid.NewGuid(), name, coordinator, place, lat, lng, fee);
    }

    public EventQueryResult[] query(float lat, float lng, int fee)
    {
        EventQueryResult result = new EventQueryResult("Nick", "Pick", "TPE", 178.5f, 23.5f, 500);
        EventQueryResult[] results = new EventQueryResult[] { result, result, result };
        return results;
    }
}