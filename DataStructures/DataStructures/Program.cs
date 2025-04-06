using DataStructures.Types;

Queue<int> queue = new();

queue.Enqueue(3);
queue.Enqueue(3000);
queue.Enqueue(13);
queue.Enqueue(34);

foreach(var item in queue)
{
    Console.WriteLine($"item: {item}");
}

var result1 = queue.Dequeue();
Console.WriteLine($"result1: {result1}; queueCount: {queue.Count}");

var result2 = queue.Dequeue();
Console.WriteLine($"result2: {result2}; queueCount: {queue.Count}");

var result3 = queue.Dequeue();
Console.WriteLine($"Final Output: result: {result3}; queueCount: {queue.Count}");

foreach (var item in queue)
{
    Console.WriteLine($"item: {item}");
}