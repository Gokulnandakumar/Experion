var DateToday = DateTime.Today; 
Console.Write("Enter your date of Birth in 'DD-MM-YYYY'=> "); 
var DOB = DateTime.Parse(Console.ReadLine());
Console.WriteLine("\n");
string[] Days = ((DateToday - DOB).ToString()).Split(".");
int Day = int.Parse(Days[0]);
var age = Day / 365;
var hours = Day * 24;
var weeks = Day / 7;
var months = Day / 30; Console.WriteLine($"Age is => {age}");
Console.WriteLine($"Age in hours => {hours} hrs");
Console.WriteLine($"Age in weeks => {weeks}");
Console.WriteLine($"Age in month => {months}");
Console.WriteLine($"Age in days => {Day}");
Console.WriteLine("\n"); if (DOB.Year % 4 == 0)
{
    Console.WriteLine($"Your birthyear {DOB.Year} is a leapyear");
}
else
{
    Console.WriteLine($"Your birthyear {DOB.Year} is not a leapyear");
}
