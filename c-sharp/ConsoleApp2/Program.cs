using ConsoleApp2;
using System.Runtime.CompilerServices;

var list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);

foreach (var item in list)
{
    Console.WriteLine(item);
}

list.Clear();

foreach (var item in list)
{
    Console.WriteLine(item);
}