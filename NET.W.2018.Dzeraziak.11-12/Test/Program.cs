using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Dzeraziak.Stopwatch;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var watch = new Watch(4);

            watch.TimeElapset += Elapsed;

        }

        public static void Elapsed(object sender, EventArgs e)
        {
            System.Console.WriteLine("Elapsed");
        }
    }
}
