namespace JAngine.Rendering.OpenGL;

public interface IBuffer<T> : IGlObject, IDisposable, IEnumerable<T>
    where T : unmanaged
{
    int Capacity { get; }
    int Count { get; }
    void EnsureCapacity(int size);
    T this[Index index] { get; set; }
    Span<T> this[Range range] { get; }
    void SetSubData(int offset, params T[] data);
    int FindIndex(T value);
}

internal sealed class UpdateDataEvent : IGlEvent
{
    internal static UpdateDataEvent Singleton { get; } = new UpdateDataEvent();

    private UpdateDataEvent()
    {
        
    }
}
internal sealed class UpdateCapacityEvent : IGlEvent
{
    internal static UpdateCapacityEvent Singleton { get; } = new UpdateCapacityEvent();

    private UpdateCapacityEvent()
    {
        
    }
}
