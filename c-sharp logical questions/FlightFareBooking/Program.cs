// Accept a flight fare and booking time
Console.WriteLine("enter flight time");
float time = float.Parse(Console.ReadLine());
Console.WriteLine("Enter flight fare");
int amount = int.Parse(Console.ReadLine());
if (time >= 6.00 && time <= 9.00 )
{
    Console.WriteLine(amount * 1.1);
}
else if (time > 9.00 && time <= 17.00)
{
    Console.WriteLine(amount * 1.2);
}
else if(time > 17.00 && time <= 23.00)
{
    Console.WriteLine(amount * 1.07);
}
else if(time > 23.00 && time <6)
{
    Console.WriteLine(amount * 1.05);
}