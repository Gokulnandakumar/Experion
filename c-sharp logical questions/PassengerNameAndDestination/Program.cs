
Console.WriteLine("enter number of passengers and destinations");
int val = int.Parse(Console.ReadLine());    
string[] name = new string[val];
string[] Destination = new string[val];

Console.WriteLine("enter passenger names");
for (int i = 0; i < name.Length; i++)
{
    name[i] = Console.ReadLine();
}
Console.WriteLine("enter passenger Destinations");
for (int i = 0; i < Destination.Length; i++)
{
    Destination[i] = Console.ReadLine();
}

Dictionary<string, string> Merge = new Dictionary<string, string>();

for (int i = 0;i < val; i++)
{
    Merge.Add(name[i], Destination[i]);
}

foreach (KeyValuePair<string, string> key in Merge)
{
    Console.WriteLine($"Passenger name is -{key.Key} and passenger Destination is {key.Value}");
}
