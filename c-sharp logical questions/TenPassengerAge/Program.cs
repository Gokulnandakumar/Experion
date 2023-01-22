
string[] Passengerage = new string[2];

Console.WriteLine("enter passenger year");
for (int i = 0; i < Passengerage.Length; i++)
{
    Passengerage[i] = Console.ReadLine();
}

var today = DateTime.Today;


for (int i = 0; i < Passengerage.Length; i++)
{
    //Console.WriteLine(DateOnly.Parse(Passengerage[i]));
    //var val = DateOnly.Parse(Passengerage[i]);
    Console.WriteLine(long.Parse(Passengerage[i]));
    DateTime birthdate = new DateTime(long.Parse(Passengerage[i]));
    var age = today.Subtract(birthdate).TotalDays;
    var years = (age / 365);
    years = Math.Round(years);
    Console.WriteLine(years);
    if (years < 10)
    {
        Console.WriteLine("kid");
    }
    else if (years > 10 && years < 30)
    {
        Console.WriteLine("Youth");
    }
    else if (years > 30 && years < 60)
    {
        Console.WriteLine("Adult");
    }
    else if (years > 60)
    {
        Console.WriteLine("Older");
    }
            
}


