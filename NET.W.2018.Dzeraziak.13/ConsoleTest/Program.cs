using System;
using Queue;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue.Queue<int>();

            queue.Enqueue(1);

            System.Console.WriteLine(queue.Dequeue());
        }
    }
}
