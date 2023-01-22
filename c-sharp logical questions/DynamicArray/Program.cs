


List<int> list = new List<int>();
Console.WriteLine("choose -1 to exit");
Console.WriteLine("enter flight numbers");
while(true)
{
    int val = int.Parse(Console.ReadLine());
    if(val != -1 )
    { 
        list.Add(val); 
    }
    else
    {
        Environment.Exit(-1);
    }
}