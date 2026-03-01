public class DNode<T>
{
    public T Value { get; set; }
    public DNode<T>? Previous { get; set; }
    public DNode<T>? Next { get; set; }

    public DNode(T value)
    {
        Value = value;
        Previous = null;
        Next = null;
    }
}