using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Check that it properly Enqueues and then Dequeues a person according to priority
    // Expected: Bob, Sue
    // Defect(s) Found: Dequeue was broken because it didn't actually remove the person from the queue
    public void TestPriorityQueue_EnDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sue", 1);

        string[] expectedResult = ["Bob", "Sue"];

        var v1 = priorityQueue.Dequeue();
        var v2 = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult[0], v1);
        Assert.AreEqual(expectedResult[1], v2);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

      [TestMethod]
    // Scenario: Empty Priority Queue
    // Expected Result: There should be an error because there shouldn't be anyone in queue to dequeue
    // Defect(s) Found:
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("No one in the queue.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}