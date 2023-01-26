using Assignment;

var obj = new Class1();
Console.WriteLine("enter x and y");
obj.x = int.Parse(Console.ReadLine());
obj.y = int.Parse(Console.ReadLine());

int res = obj.Display();
Console.WriteLine($" value of x + y is {res}");