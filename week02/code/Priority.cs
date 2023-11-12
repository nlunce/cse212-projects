/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities and dequeue
        // Expected Result: Dequeue items in the order of highest priority

        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sam", 3);
        priorityQueue.Enqueue("Bill", 1);
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: Sam
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: Bob
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: Bill
        // Defect(s) Found: The loop condition in the Dequeue method is incorrect. 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Attempt to dequeue from an empty queue
        // Expected Result: Display an error message
        Console.WriteLine("Test 2");
         Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found:  The code does not handle the case of attempting to dequeue from an empty queue correctly

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        
        //Scenario: Two items with the same priority.
        // Expected Result: Greg
        //                  [Bob (Pri:2), Bill (Pri:5), Tom (Pri:1)]
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Greg", 5);
        priorityQueue.Enqueue("Bill", 5);
        priorityQueue.Enqueue("Tom", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Removed the last item that was added to the queue instead of the first.

        Console.WriteLine("---------");

    }
}