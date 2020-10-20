using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the class
            var myList = new SortedListArray();

            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            myList.Add(new Item { ProductName = "milk", Quantity = 1 });
            myList.Add(new Item { ProductName = "apples", Quantity = 1 });
            myList.Add(new Item { ProductName = "biscuits", Quantity = 2 });
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });

            // List the items in the list
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{ myList.Retrieve(i).ProductName} \t {myList.Retrieve(i).Quantity}");
            }
            Console.WriteLine();


            // Remove carrots
            myList.Remove(new Item { ProductName = "carrots" });


            // List the items in the list again
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{ myList.Retrieve(i).ProductName} \t {myList.Retrieve(i).Quantity}");
            }

            // Ask the user for an item and output its position in the list
            Console.Write("Enter item to be searched: ");
            string name = Console.ReadLine();
            int position;
            bool found = myList.Found(new Item { ProductName = name }, out position);
            if (found)
            {
                Console.WriteLine($"Found at postion: {position}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadLine();
        }
    }
}
