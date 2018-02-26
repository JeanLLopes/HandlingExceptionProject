using ExceptionsLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demoCode = new DemoCode();
            Console.WriteLine($"this value at the givem position is {demoCode.GrandParentMethod(3)}");
            Console.ReadLine();

        }
    }
}
