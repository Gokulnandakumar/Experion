

//------Odd number range F101, F103...F110--------------
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("enter a alphabet");
char val = char.Parse(Console.ReadLine());

for (int i = 101; i < 110; i+= 2)
{
    string res = i.ToString();
    res = val + res;
    Console.WriteLine($" required string is {res} ");
}


//--------Even number range W100, W102...W110-----------
Console.WriteLine("enter a alphabet");
char alpha= char.Parse(Console.ReadLine());
for (int i = 102; i < 110; i += 2)
{
    string res = i.ToString();
    res = alpha + res;
    Console.WriteLine($" required string is {res} ");
}

//---------First 10 prime numbersstarting with Q----------

char first = 'Q';
Console.WriteLine("First 10 prime numbers");

int j = 0;
while (j <= 30)
{
    if (j % 2 == 0 || j % 5 == 0)
    {
        j++;
        continue;
    }
    string res = first + j.ToString();
    Console.WriteLine($"{res}");
    j++;
}

//------------First 10 fibonacci numbers starting with N-------------

int zeroth = 0;
int one = 1;
int sum = zeroth + one;
while (sum < 50)
{
    sum = sum + one;

}


//------------First 10 Armstrong numbers starting with A-------------

Console.WriteLine("armstong number");
char p = 'A';
for (int i = 0; i < 1000; i++)
{
    int copy = i;
    //Console.WriteLine(copy);
    int cube = 0;
    while (copy!=0)
    {
        int a = (copy % 10);
        //Console.WriteLine(a);
        cube = cube + (a * a * a);
        copy = copy / 10;
    }
    //Console.WriteLine(cube);
    if( i == cube)
    {

        Console.WriteLine($"{p+cube.ToString()}");
    }
}




