// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter your values");
string[] arr = new string[4];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Console.ReadLine();
}
Console.WriteLine("Your  Sorted array =");
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write("\t" + arr[i]);
}

//Reverse ordrer

Console.WriteLine("\r\nThe Reverse Order = ");
Array.Reverse(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

// array serach
Console.WriteLine("enter search name");
string name = Console.ReadLine();   
for (int i = 0; i < arr.Length; i++)
{
    if(name == arr[i])
    {
        Console.WriteLine( "your name found",i);
    }
}

// array split
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        if (arr[i][j] == ' ')
        {
            int val = arr[i].Length;
            Range range = j..val;
            foreach (string k in arr[range]) {

                Console.WriteLine(k);

            }
        }
    }
}


