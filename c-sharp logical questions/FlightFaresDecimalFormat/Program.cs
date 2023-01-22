// ----------Read decimal array---------------------------

Console.WriteLine("enter limit");
int val = int.Parse(Console.ReadLine());
decimal[] arr = new decimal[val];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = decimal.Parse(Console.ReadLine());
}

//----------Ascending Order-------------------------------

Console.WriteLine("Ascending order");
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            decimal temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

//--------------Descending order sort-----------------------

Console.WriteLine("Descending sort");
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            decimal temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

//----------Input a fare and search in the array-----------------

Console.WriteLine("enter search value");
decimal search = decimal.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    if (search == arr[i])
    {
        Console.WriteLine($"value found at pos {i + 1} and value is {arr[i]}");
    }
}

//---------Print the max and min fares----------------------------

Console.WriteLine("Maximum fare");

decimal maximum = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] > arr[j] && arr[i] > maximum)
        {
            maximum = arr[i];
        }
    }
}
Console.WriteLine(maximum);

Console.WriteLine("Minimum Fare is");
decimal minimum = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] < arr[j] && arr[i] < minimum)
        {
            minimum = arr[i];
        }
    }
}
Console.WriteLine(minimum);

//---------print duplicate values---------------

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine($"duplicate value found at {i+1} value is {arr[i]}");
        }
    }
}