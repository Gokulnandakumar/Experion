using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    internal class Person
    {
        public int x;
        public int y;

        public void Display()
        {
            Console.WriteLine($"your numbers are {x} and {y}");
        }
    }
}
