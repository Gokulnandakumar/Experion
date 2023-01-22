
Console.WriteLine("enter passenger name");
string name = Console.ReadLine();
Console.WriteLine("enter miles travelled");
int miles = int.Parse(Console.ReadLine());

if(miles >= 10000 && miles < 20000)
{
    Console.WriteLine($"Flyer points of customer - {name} is 10");
}
else if(miles >= 20000 && miles < 50000)
{
    Console.WriteLine($"Flyer points of customer - {name} is 20");
}
else if(miles > 50000 && miles < 100000)
{
    Console.WriteLine($"Flyer points of customer - {name} is 30");
}
else if(miles > 100000)
{
    Console.WriteLine($"Flyer points of customer - {name} is 50");
}
