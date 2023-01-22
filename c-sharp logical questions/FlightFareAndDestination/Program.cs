
Console.WriteLine("enter number of destination and fares");

int n = int.Parse(Console.ReadLine());
decimal[] fare = new decimal[n];
string[] destination = new string[n];

Console.WriteLine("enter fare");
for (int i = 0;i < n; i++)
{
    fare[i] = decimal.Parse(Console.ReadLine());
}

Console.WriteLine("enter destination");
for (int i = 0;i < n; i++)
{
    destination[i] = Console.ReadLine();
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Destination is {destination[i]} and corresponding fare is {fare[i]}");
}
