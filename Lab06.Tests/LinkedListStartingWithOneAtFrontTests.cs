using NUnit.Framework;

[TestFixture]
public class LinkedListStartingWithOneAtFrontTests
{
    private DoublyLinkedList<int> _list;

    [SetUp]
    public void Setup()
    {
        _list = new DoublyLinkedList<int>();
        _list.AddFirst(10);
    }

    [Test]
    public void AddLastWorks()
    {
        _list.AddLast(20);
        Assert.That(_list.Length, Is.EqualTo(2));
        Assert.That(_list.Last, Is.EqualTo(20));
    }

    [Test]
    public void AddFirstWorks()
    {
        _list.AddFirst(5);
        Assert.That(_list.Length, Is.EqualTo(2));
        Assert.That(_list.First, Is.EqualTo(5));
    }

    [Test]
    public void RemoveLastWorks()
    {
        _list.RemoveLast();
        Assert.That(_list.Length, Is.EqualTo(0));
    }

    [Test]
    public void RemoveFirstWorks()
    {
        _list.RemoveFirst();
        Assert.That(_list.Length, Is.EqualTo(0));
    }
}