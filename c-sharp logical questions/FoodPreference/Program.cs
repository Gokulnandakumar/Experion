
Dictionary<int, string> food = new Dictionary<int, string>();
Console.WriteLine("enter name and seat of 10 passengers");
for (int i = 0; i < 4; i++)
{
    string VegOrNonVeg = Console.ReadLine();
    int seat = int.Parse(Console.ReadLine());
    food.Add(seat, VegOrNonVeg);
}

//foreach(var i in food)
//{
//    Console.WriteLine(i.Value);
//    Console.WriteLine(i.Key);
//}

object[,] hostess = new object[5,5];

foreach (var item in food)
{
    int res = item.Key % 5;
    if (item.Key < 5)
    {
        hostess[0, res] = item.Value;
    }
    else if (item.Key >= 5 && item.Key < 10) 
    {
        hostess[1, res] = item.Value;
    }
    else if(item.Key >= 10 && item.Key < 15)
    {
        hostess[2, res] = item.Value;
    }
    else if(item.Key >= 15 && item.Key < 20)
    {
        hostess[3, res] = item.Value;
    }
    else if(item.Key >= 20 && item.Key < 25)
    {
        hostess[4, res] = item.Value;
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(hostess[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine("\n");
}
  
