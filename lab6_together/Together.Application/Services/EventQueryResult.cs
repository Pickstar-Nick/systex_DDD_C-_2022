namespace Together.Appliction.Services;
public record EventQueryResult(
    string name,
    string coordinator,
    string place,
    float lat,
    float lng,
    int fee
);