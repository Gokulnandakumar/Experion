
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
int minvalue = 0;
int mindistance = 0;
for (int i = 0; i < val; i++)
{
    for (int k = 0; k < val; k++)
    {
        for (int j = 3; j < 4; j++)
        {
            int val1 = int.Parse(arr[i, j]);
            int val2 = int.Parse(arr[k, j]);
            if (val1 > val2)
            {
                minvalue = val1;
            }
        }
        for (int v = 2; v < 3; v++)
        {
            int val1 = int.Parse(arr[i, v]);
            int val2 = int.Parse(arr[k, v]);
            if (val1 < val2)
            {
                mindistance = val1;
            }
        }
    }
}
Console.WriteLine($"smallest distance is {mindistance} and smallest fare is {minvalue}");
int lowfare = 0;
int lowpath = 0;
for (int i = 0; i < val; i++)
{
    for (int k = 0; k < val; k++)
    {
        for (int j = 3; j < 4; j++)
        {
            int val1 = int.Parse(arr[i, j]);
            int val2 = int.Parse(arr[k, j]);
            if (val1 < val2)
            {
                lowfare = val1;
            }
        }
        for (int v = 2; v < 3; v++)
        {
            int val1 = int.Parse(arr[i, v]);
            int val2 = int.Parse(arr[k, v]);
            if (val1 < val2)
            {
                lowpath = val1;
            }
        }
    }
}
Console.WriteLine($"smallest distance is {lowpath} and smallest fare is {lowfare}");
