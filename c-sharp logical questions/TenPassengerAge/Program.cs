
object[] Passengerage = new object[10];
var DateToday = DateTime.Today;

Console.Write("Enter your date of Birth in 'DD-MM-YYYY'=> ");
for (int i = 0; i < Passengerage.Length; i++)
{
    var Dob = DateTime.Parse(Console.ReadLine());
    Passengerage[i] = Dob;
    string[] Days = ((DateToday - Dob).ToString()).Split(".");
    int Day = int.Parse(Days[0]);
    var age = Day / 365;
    if (age < 10)
    {
        Console.WriteLine("kid");
    }
    else if (age > 10 && age < 30)
    {
        Console.WriteLine("Youth");
    }
    else if (age > 30 && age < 60)
    {
        Console.WriteLine("Adult");
    }
    else if( age >60)
    {
        Console.WriteLine("older");
    }
}



