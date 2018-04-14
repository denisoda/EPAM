using System;
using Queue;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue.Queue<int>();

            for(int i = 0; i < 10; i++)
                    queue.Enqueue(i);

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
