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
                Console.WriteLine("Open DataBase Connections");

                var position = 10;
                if (position > 0)
                {
                    Console.WriteLine($"this value at the givem position is {demoCode.GrandParentMethod(position)}");
                }
                else
                {
                    throw new IndexOutOfRangeException("Please pass a value bigger the 0");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("You give us a bad information, bad user");
            }       
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                while (ex.InnerException != null)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            finally
            {
                Console.WriteLine("Close all DataBase connections");
            }
            Console.ReadLine();
        }
    }
}
