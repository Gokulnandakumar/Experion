
using System.Security.Cryptography;

Random random= new Random();


Queue<int> FirstQueue = new Queue<int>();
Queue<int> SecondQueue = new Queue<int>();
Queue<int> ThirdQueue = new Queue<int>();

// accept 10 passengers
int[] BoardingPass = new int[11];

Console.WriteLine("enter 10 passenger boarding details");
for (int i = 0; i <= 10; i++)
{
    BoardingPass[i] = int.Parse(Console.ReadLine()); 
    if(FirstQueue.Count <3)
    {
        FirstQueue.Enqueue(BoardingPass[i]);
        Console.WriteLine($"id {BoardingPass[i]} is inserted in position in FirstQueue");
    }
    else if(SecondQueue.Count <3)
    {
        SecondQueue.Enqueue(BoardingPass[i]);
        Console.WriteLine($"id {BoardingPass[i]} is inserted in position in SecondQueue");
    }
    else if(ThirdQueue.Count <3)
    {
        ThirdQueue.Enqueue(BoardingPass[i]);
        Console.WriteLine($"id {BoardingPass[i]} is inserted in position in ThirdQueue");
    }
    else
    {
        //Console.WriteLine($"space for boarding pass {BoardingPass[i]} is not available");

        int val = random.Next(1,3);
        if( val == 0 )
        {
            FirstQueue.Dequeue();
            FirstQueue.Enqueue(BoardingPass[i]);
            Console.WriteLine($"{BoardingPass[i]} is inserted in first queue");
        }
        else if( val == 1)
        {
            SecondQueue.Dequeue();
            SecondQueue.Enqueue(BoardingPass[i]);
            Console.WriteLine($"{BoardingPass[i]} is inserted in second queue");
        }
        else if( val == 2)
        {
            ThirdQueue.Dequeue();
            ThirdQueue.Enqueue(BoardingPass[i]);
            Console.WriteLine($"{BoardingPass[i]} is inserted in Third queue");
        }
    }
}
