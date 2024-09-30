using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // * Scenario: Enqueue multiple items w/ diff personalities & dequeue properly
    // ? Expected Result: high1, high2, medium, low1, low2
    // ! Defect(s) Found: Highest priority item not dequeued first, items not removed from queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low1", 1);
        priorityQueue.Enqueue("High1", 3);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("Low2", 1);
        priorityQueue.Enqueue("High2", 3);

        string[] expectedResult = { "High1", "High2", "Medium", "Low1", "Low2" };

        for (int i = 0; i < expectedResult.Length; i++)
        {
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue(), $"Item {i + 1} dequeued incorrectly");
        }
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // * Scenario: dequeue from an empty que, then enqueue and dequeue again
    // ? Expected Result: throw exception for empty queue
    // ! Defect(s) Found: Dequeuing doesn't remove items
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Should throw exception when dequeuing from empty queue");

        // refill & test again
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 2);

        string[] expectedResult = { "Second", "First" };

        for (int i = 0; i < expectedResult.Length; i++)
        {
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue(), $"Item {i + 1} dequeued incorrectly.");
        }

        // queue should be empty again
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Should throw exception when dequeuing from empty queue");
        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}