using System;

namespace PL.Console
{
    class Program
    {
        static void Main(string[] args)
        {
                System.Console.WriteLine("Hello World");
                System.Console.ReadLine();
                Test(new Crash());
        }

        public static void Test(Crash crash)
        {
            crash.Run();
        }

    }

    public class Crash
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
