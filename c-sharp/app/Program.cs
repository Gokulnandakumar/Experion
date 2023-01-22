
using System.Collections.Immutable;


// sort passenger array.
Console.WriteLine("enter the number of passengers");
int arrayLength = int.Parse(Console.ReadLine());
string[] arr = new string[arrayLength];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Console.ReadLine();
}

Array.Sort(arr);
Console.WriteLine("After sorting");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


//reverse array

Console.WriteLine("reversed array");
Array.Reverse(arr);

for (int i = arr.Length-1; i >= 0; i--)
{
    Console.WriteLine(arr[i]);
}

Console.ReadKey();




