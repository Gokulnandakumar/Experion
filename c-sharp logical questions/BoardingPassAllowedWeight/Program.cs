
//

using System.Runtime.CompilerServices;

Dictionary<string, int> OverWeight = new Dictionary<string, int>();
Console.WriteLine("enter customer name and total kgs");
List<int> list = new List<int>();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("enter name of passenger");
    string name = Console.ReadLine();
    Console.WriteLine("enter passenger baggage total weight");
    int total = int.Parse(Console.ReadLine());

    OverWeight.Add(name, total);
}

    foreach (var item in OverWeight)
    {
        if (item.Value > 23)
        {
            int cal = item.Value - 23;
            int additionalCharge = cal * 15;
            list.Add(additionalCharge);
            Console.WriteLine($"Additional charge is - {additionalCharge}$ for passenger {item.Key}");
        }
        else
        {
            Console.WriteLine($"Additional charge is {0} for passenger {item.Key}");
        }
    }
    //Console.WriteLine($"total additional weight of passengers are {sum}");

Console.WriteLine("sorted passenger weight");
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);
}


