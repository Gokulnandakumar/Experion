
Console.WriteLine("enter number of values");
int val = int.Parse(Console.ReadLine());
object[,] arr = new object[val, 4];

Console.WriteLine("enter array values");
for (int i = 0; i < val; i++)
{
	for (int j = 0; j < 4; j++)
	{
		arr[i,j] = Console.ReadLine();
	}
}

// Shortest Distance

int ShortDistance = int.MaxValue;

for (int i = 0; i < val - 1; i++)
{
    int j = i + 1;
    for (int k = 2; k < 3; k++)
    {
        int val1 = Convert.ToInt32(arr[i, k]);
        int val2 = Convert.ToInt32(arr[j, k]);
        if (val1 < val2 && val1 < ShortDistance)
        {
            ShortDistance = val1;
        }
        else
        {
            if (val2 < val1 && val2 < ShortDistance)
            {
                ShortDistance = val2;
            }
        }
    }
}
Console.WriteLine($"Shortest distance is {ShortDistance}");

// Largest Distance
int LargeDistance = 0;

for (int i = 0; i < val-1; i++)
{
	int j = i+1;
	for (int k = 2; k < 3; k++)
	{
		int val1 = Convert.ToInt32(arr[i, k]); 
		int val2 = Convert.ToInt32(arr[j, k]);
		if( val1 > val2 && val1 > LargeDistance)
		{
			LargeDistance = val1;
		}
		else
		{
			if (val2 > val1 && val2 > LargeDistance)
			{
				LargeDistance = val2;
			}
        }
	}
}
Console.WriteLine($"Largest distance is {LargeDistance}");

// SmallestFare

int SmallFare = int.MaxValue;

for (int i = 0; i < val - 1; i++)
{
    int j = i + 1;
    for (int k = 3; k <= 3; k++)
    {
        int val1 = Convert.ToInt32(arr[i, k]);
        int val2 = Convert.ToInt32(arr[j, k]);
        if (val1 < val2 && val1 < SmallFare)
        {
            SmallFare = val1;
        }
        else
        {
            if (val2 < val1 && val2 < SmallFare)
            {
                SmallFare = val2;
            }
        }
    }
}
Console.WriteLine($"Smallest Fare is {SmallFare}");

// HighestFare

int HighestFare = 0;

for (int i = 0; i < val - 1; i++)
{
    int j = i + 1;
    for (int k = 3; k <= 3; k++)
    {
        int val1 = Convert.ToInt32(arr[i, k]);
        int val2 = Convert.ToInt32(arr[j, k]);
        if (val1 > val2 && val1 > HighestFare)
        {
            HighestFare = val1;
        }
        else
        {
            if (val2 > val1 && val2 > HighestFare)
            {
                HighestFare = val2;
            }
        }
    }
}
Console.WriteLine($"Highest Fare is {HighestFare}");

// Shortest path with Smallest fare


