using NUnit.Framework;

[TestFixture]
public class LinkedListStartingWithTwoTests
{
    private DoublyLinkedList<int> _list;

    [SetUp]
    public void Setup()
    {
        _list = new DoublyLinkedList<int>();
        _list.AddLast(1);
        _list.AddLast(2);
    }

    [Test]
    public void RemoveFirstThenLastResultsInEmpty()
    {
        _list.RemoveFirst();
        _list.RemoveLast();
        Assert.That(_list.Length, Is.EqualTo(0));
    }
}