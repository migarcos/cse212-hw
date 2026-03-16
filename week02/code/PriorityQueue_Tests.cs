using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Addig elements and testing with different priority
    // Expected Result: value4
    // Defect(s) Found: It fails when the last value has the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
                                            //  w   w   f   w
        priorityQueue.Enqueue("value1", 3); //  5   3   3   6
        priorityQueue.Enqueue("value2", 1); //  3   6   1   3
        priorityQueue.Enqueue("value3", 5); //  6   1   5   5
        priorityQueue.Enqueue("value4", 6); //  1   5   6   1
        // priorityQueue.Enqueue("value5", 7); 
        
        var result = priorityQueue.Dequeue();        

        Assert.AreEqual("value4", result);        
    }

    [TestMethod]
    // Scenario: Adding elements with same priority
    // Expected Result: value1
    // Defect(s) Found: Dequeue the idx 3
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("value1", 1);
        priorityQueue.Enqueue("value2", 5);
        priorityQueue.Enqueue("value3", 1);
        priorityQueue.Enqueue("value4", 5);
        
        var result = priorityQueue.Dequeue();        

        Assert.AreEqual("value2", result);
    }

    // Add more test cases as needed below.
}