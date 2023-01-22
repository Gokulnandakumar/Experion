
Console.WriteLine("enter number of passengers");

int passengers = int.Parse(Console.ReadLine());

double[] arr = new double[passengers];

Console.WriteLine("enter choice");
Console.WriteLine("1. odd position");
Console.WriteLine("2. even position");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        for (int i = 2; i < passengers; i+=2)
        {
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        break;
    case 2:
        for (int i = 0; i < passengers; i+=2)
        {
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        break;

}



for(int i = 0 ;i < passengers; i++)
{
    Console.WriteLine(arr[i]);
}