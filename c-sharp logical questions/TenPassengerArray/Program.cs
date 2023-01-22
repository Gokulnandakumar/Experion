//-------------- Read 10 Passengers----------------------
Console.WriteLine("Enter 10 passenger names");
string[] arr = new string[4];

for (int i = 0;i < 4; i++)
{
    arr[i] = Console.ReadLine();
}

// -------------Print alphabetic order--------------------


for (int i = 0;i < arr.Length; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
       int result = string.CompareOrdinal(arr[i], arr[j]);
        if(result > 0)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

Console.WriteLine("after sorting");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

//--------------Print reverse order---------------

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        int result = string.CompareOrdinal(arr[i], arr[j]);
        if (result < 0)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

Console.WriteLine("after sorting reverse order");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

//------Input a name and search in array and display-------

Console.WriteLine("Enter name to search");
string search = Console.ReadLine();

for (int i = 0; i < arr.Length; i++)
{
    if(search == arr[i]) 
    {
        Console.WriteLine($"found name {arr[i]} at position {i+1}");
    }
}

//-------Print the length of names in each element----------

int count = 0;
for (int i = 0;i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        count++;
    }
    Console.WriteLine($"length of string at {i} is {count}");
    count = 0;
}

// -------------Split the names at space and print for each element--------

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        if (arr[i][j] == ' ')
        {
            int FirstPos = 0;
            int CurentPos = j + 1;
            while (FirstPos < CurentPos)
            {
                Console.Write(arr[i][FirstPos]);
                FirstPos++;
            }
            Console.Write("\n");
            while(CurentPos < arr[i].Length)
            {
                Console.Write(arr[i][CurentPos]);
                CurentPos++;
            }
            Console.Write("\n");
        }
    }
}

// -----------------Print duplicate entries-----------------

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine($"Duplicate found at position {i} name-{arr[i]}");
        }
    }
}



