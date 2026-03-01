public class DoublyLinkedList<T> : IDoubleEndedCollection<T>
{
    private DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    public int Length { get; private set; } = 0;

    public T First => _head!.Value;
    public T Last => _tail!.Value;

    public void AddLast(T value)
    {
        var node = new DNode<T>(value);
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail!.Next = node;
            node.Previous = _tail;
            _tail = node;
        }
        Length++;
    }

    public void AddFirst(T value)
    {
        var node = new DNode<T>(value);
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            node.Next = _head;
            _head.Previous = node;
            _head = node;
        }
        Length++;
    }

    public void RemoveLast()
    {
        if (Length == 1)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _tail = _tail!.Previous;
            _tail!.Next = null;
        }
        Length--;
    }

    public void RemoveFirst()
    {
        if (Length == 1)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _head = _head!.Next;
            _head!.Previous = null;
        }
        Length--;
    }

    public void InsertAfter(DNode<T> node, T value)
    {
        var newNode = new DNode<T>(value);
        newNode.Next = node.Next;
        newNode.Previous = node;
        if (node.Next != null)
            node.Next.Previous = newNode;
        else
            _tail = newNode;
        node.Next = newNode;
        Length++;
    }

    public void RemoveByValue(T value)
    {
        var current = _head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
            {
                if (current.Previous != null)
                    current.Previous.Next = current.Next;
                else
                    _head = current.Next;

                if (current.Next != null)
                    current.Next.Previous = current.Previous;
                else
                    _tail = current.Previous;

                Length--;
                return;
            }
            current = current.Next;
        }
    }

    public void ReverseList()
    {
        var current = _head;
        DNode<T>? temp = null;
        _tail = _head;

        while (current != null)
        {
            temp = current.Previous;
            current.Previous = current.Next;
            current.Next = temp;
            current = current.Previous;
        }

        if (temp != null)
            _head = temp.Previous;
    }
}