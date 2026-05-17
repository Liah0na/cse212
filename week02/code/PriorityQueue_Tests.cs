using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 items where the highest priority item is last in the queue.
    // Expected Result: The item with the highest priority should be returned.
    // Defect(s) Found: The loop does not evaluate the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Lorem", 1);
        priorityQueue.Enqueue("Ipsum", 5);
        priorityQueue.Enqueue("Dolor", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Dolor", result);
    }

    [TestMethod]
    // Scenario: Add 3 items where the highest priority item is middle in the queue.
    // Expected Result: The item with the highest priority should be returned.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Lorem", 1);
        priorityQueue.Enqueue("Ipsum", 15);
        priorityQueue.Enqueue("Dolor", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Ipsum", result);
    }

    [TestMethod]
    // Scenario: Add 5 items where the highest priority item is first in the queue.
    // Expected Result: The item with the highest priority should be returned.
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Amet", 11);
        priorityQueue.Enqueue("Consectetur", 1);
        priorityQueue.Enqueue("Dolor", 2);
        priorityQueue.Enqueue("Ipsum", 5);
        priorityQueue.Enqueue("Dolor", 2);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Amet", result);
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException should be thrown.
    // Defect(s) Found: None.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }

    [TestMethod]
    // Scenario: Remove two items from the queue.
    // Expected Result: The second dequeue should return the next highest priority item.
    // Defect(s) Found: The item is not removed from the queue after dequeueing.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Lorem", 1);
        priorityQueue.Enqueue("Ipsum", 5);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("Ipsum", first);
        Assert.AreEqual("Lorem", second);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority.
    // Expected Result: The item closest to the front should be returned first.
    // Defect(s) Found: Using >= returns the last matching item instead of the first.
    public void TestPriorityQueue_6()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Lorem", 5);
        priorityQueue.Enqueue("Ipsum", 5);
        priorityQueue.Enqueue("Dolor", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Lorem", result);
    }
}