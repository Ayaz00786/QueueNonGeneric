using System;
using System.Collections;

namespace QueueNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

        //-----------Queue Enqueue-------------

            queue.Enqueue("php");
            queue.Enqueue("java");
            queue.Enqueue("html");
            queue.Enqueue("css");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

        //---------Queue Dequeue----------------

            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
