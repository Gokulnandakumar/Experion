
Queue<int> FirstQueue = new Queue<int>();
Queue<int> SecondQueue = new Queue<int>();
Queue<int> ThirdQueue = new Queue<int>();

// accept 10 passengers
int[] BoardingPass = new int[10];

Console.WriteLine("enter 10 passenger boarding details");
for (int i = 0; i < 10; i++)
{
    BoardingPass[i] = int.Parse(Console.ReadLine()); 
    if(FirstQueue.Count <= 3)
    {
        FirstQueue.Enqueue(BoardingPass[i]);
        Console.WriteLine($"id {BoardingPass[i]} is inserted in position {i} in FirstQueue");
    }
    else if(SecondQueue.Count <=3)
    {
        SecondQueue.Enqueue(BoardingPass[i]);
        Console.WriteLine($"id {BoardingPass[i]} is inserted in position {i} in SecondQueue");
    }
    else if(ThirdQueue.Count <=3)
    {
        ThirdQueue.Enqueue(BoardingPass[i]);
        Console.WriteLine($"id {BoardingPass[i]} is inserted in position {i} in ThirdQueue");
    }
    else
    {
        Console.WriteLine($"space for boarding pass {BoardingPass[i]} is not available");
    }
}
