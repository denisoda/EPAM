using System;
using Dzeraziak.Stopwatch;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Watch(4);
        }

        public static void Elapsed(object sender, EventArgs e)
        {
            System.Console.WriteLine("Elapsed");
        }
    }
    public class Adder
    {
        public event EventHandler OnMultiple;

        public int add(int a, int b)
        {
            int iSum = a + b;

            OnMultiple(this, EventArgs.Empty);

            return iSum;
        }
    }

}
