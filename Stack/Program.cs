using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a Stack of strings call myStack
            var myStack = new StackArray<string>();

            myStack.Push("apples");
            myStack.Push("milk");
            myStack.Push("ham");
            myStack.Push("pears");

            Console.WriteLine("Number of items in stack: " + myStack.Count);
            Console.Write("Peeking the top: ");
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("Popping all elements");

            // Pop and output all the elements of the 
            while (!myStack.Empty())
            {
                Console.WriteLine(myStack.Pop());
            }


            Console.ReadLine();
        }
    }
}
