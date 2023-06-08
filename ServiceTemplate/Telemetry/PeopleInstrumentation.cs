using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace {{RootNamespace}}.Telemetry;

public class PeopleInstrumentation : IPeopleInstrumentation, IDisposable
{
    private readonly Meter _meter;
    internal const string ActivitySourceName = "{{RootNamespace}}.People";
    internal const string MeterName = "{{RootNamespace}}.People";
    
    public PeopleInstrumentation()
    {
        
        string? version = typeof(PeopleInstrumentation).Assembly.GetName().Version?.ToString();
        ActivitySource = new ActivitySource(ActivitySourceName, version);
        _meter = new Meter(MeterName, version);
        GetAllPeopleCounter =
            _meter.CreateCounter<long>("{{RootNamespace}}.getall", "The number of calls to GetAllPeople endpoint");
    }
    
    public ActivitySource ActivitySource { get; }
    
    public Counter<long> GetAllPeopleCounter { get; }

    public void Dispose()
    {
        ActivitySource.Dispose();
        _meter.Dispose();
    }
}

public interface IPeopleInstrumentation
{
    ActivitySource ActivitySource { get; }

    Counter<long> GetAllPeopleCounter { get; }
}