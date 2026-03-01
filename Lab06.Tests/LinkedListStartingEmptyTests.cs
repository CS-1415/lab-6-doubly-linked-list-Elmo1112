using NUnit.Framework;

[TestFixture]
public class LinkedListStartingEmptyTests
{
    private DoublyLinkedList<int> _list;

    [SetUp]
    public void Setup() => _list = new DoublyLinkedList<int>();

    [Test]
    public void HasCorrectLength() => Assert.That(_list.Length, Is.EqualTo(0));

    [Test]
    public void SingleAddLastWorks()
    {
        _list.AddLast(5);
        Assert.That(_list.Length, Is.EqualTo(1));
        Assert.That(_list.Last, Is.EqualTo(5));
    }

    [Test]
    public void SingleAddFirstWorks()
    {
        _list.AddFirst(3);
        Assert.That(_list.Length, Is.EqualTo(1));
        Assert.That(_list.First, Is.EqualTo(3));
    }
}