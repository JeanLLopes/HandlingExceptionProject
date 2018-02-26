using ExceptionsLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demoCode = new DemoCode();
            try
            {
                Console.WriteLine($"this value at the givem position is {demoCode.GrandParentMethod(3)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
