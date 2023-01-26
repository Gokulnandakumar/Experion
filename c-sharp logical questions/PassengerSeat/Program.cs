string[,] arr = new string[5, 5]
{
    {"NB","NB","NB","NB","NB"},
    {"NB","NB","NB","NB","NB"},
    {"NB","NB","NB","NB","NB"},
    {"NB","NB","NB","NB","NB"},
    {"NB","NB","NB","NB","NB"}
};


while (true)
{
    Console.WriteLine(" enter your option");
    var option = Console.ReadLine();
    switch (option)
    {
        case "1":
            AddElement(int.Parse(option));
            break;
        case "2":
            AddElement(int.Parse(option));
            break;
        case "3":
            AddElement(int.Parse(option));
            break;
        case "4":
            AddElement(int.Parse(option));
            break;
        case "5":
            AddElementFive(int.Parse(option));
            break;
        case "q":
            Environment.Exit(0);
            break;
        default: break;
    }
}

void AddElement(int val)
{
    int count = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if ( count < val)
            {
                if (arr[i, j] == "NB")
                {
                    arr[i, j] = Console.ReadLine();
                    count++;
                }
            }
        }
    }
    // display matrix

    for (int v = 0; v < 5; v++)
    {
        for (int s = 0; s < 5; s++)
        {
            Console.Write(arr[v, s]);
        }
        Console.WriteLine("\n");
    }
}
void AddElementFive(int val)
{
    int i = 0;
    int j = 0;
    while (i < 5)
    {
        if (val == 5)
        {
            if (arr[i, j] == "NB")
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine(".......");
                    arr[i, k] = Console.ReadLine();
                }
                break;     
            }
            else
            {
                Console.WriteLine("No Continous space is available");
            }
        }
        i++;
    }

    for (int v = 0; v < 5; v++)
    {
        for (int s = 0; s < 5; s++)
        {
            Console.Write(arr[v, s]);
        }
        Console.WriteLine("\n");
    }
}
