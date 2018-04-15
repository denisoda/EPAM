using System;
using Stopwatch;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Adder a = new Adder();

            a.OnMultiple += Do;

            a.add(1, 5);
        }

        static void Do(object sender, EventArgs e)
        {
            System.Console.WriteLine("Doing..");
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
