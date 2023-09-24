namespace JAngine.Rendering.OpenGL;

internal interface IGlEvent
{
    
}

internal interface IGlObject
{
    internal uint Handle { get; }
    internal Window Window { get; }
    internal void DispatchEvent(IGlEvent glEvent);
}

internal sealed class CreateEvent : IGlEvent
{
    internal static CreateEvent Singleton { get; } = new CreateEvent();

    private CreateEvent()
    {
        
    }
}
internal sealed class DisposeEvent : IGlEvent
{
    internal static DisposeEvent Singleton { get; } = new DisposeEvent();

    private DisposeEvent()
    {
        
    }
}