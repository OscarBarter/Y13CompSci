using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new AQueue<string>();

            for (int i = 1; i <= 8; i++)
            {
                myQueue.Enqueue("item " + i.ToString());
            }

           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myQueue.Dequeue() + " dequeued");
            }


            myQueue.Enqueue("item 9");
            myQueue.Enqueue("item 10");

            Console.WriteLine("\nContent of the array: ");
            for (int i = 0; i < myQueue.QueueArray.Length; i++)
            {
                Console.WriteLine(myQueue.QueueArray[i]);
            }

            Console.ReadLine();
        }
    }
}
