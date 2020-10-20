using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class ListArray
    {
        protected Item[] arrayOfItems;
        protected int numItems;
        protected int capacity;

        public int Count
        {
            get { return numItems; }
        }

        public ListArray() : this(capacity: 100)
        {
        }

        public ListArray(int capacity)
        {
            arrayOfItems = new Item[capacity];
            this.capacity = capacity;
            numItems = 0;
        }

        public virtual void Add(Item item)
        {
            if (!Full())
            {
                arrayOfItems[numItems] = item;
                numItems++;
            }
            if (numItems > (arrayOfItems.Length - 10))
            {
                Array.Resize(ref arrayOfItems, arrayOfItems.Length + 100);
            }
        }

        public bool Full()
        {
            return numItems >= arrayOfItems.Length;
        }

        public bool Empty()
        {
            return numItems == 0;
        }

        public virtual bool Remove(Item item)
        {
            // Removes all items that match item. 
            // Returns true if there was any.
            int location = 0;
            bool result = false;
            while (location < numItems)
            {
                if (arrayOfItems[location].ProductName == item.ProductName)
                {
                    arrayOfItems[location] = arrayOfItems[numItems - 1];
                    numItems--;
                    location--; // to ensure item moved up is checked
                    result = true;
                }
                location++;
            }
            if (numItems < arrayOfItems.Length - 105)
            {
                Array.Resize(ref arrayOfItems, arrayOfItems.Length - 100);
            }
            return result;
        }

        public virtual void RemoveAt(int index)
        {
            if (numItems >= index)
            {
                arrayOfItems[index] = arrayOfItems[numItems];
                numItems--;
            }
        }

        public Item Retrieve(int index)
        {
            if (index <= numItems)
            {
                return arrayOfItems[index];
            }
            else
            {
                throw new InvalidOperationException("Index out of boundaries");
            }
        }

        public virtual bool Found(Item item, out int position)
        {
            for (int i = 0; i < numItems; i++)
            {
                if (arrayOfItems[i].ProductName == item.ProductName)
                {
                    position = i;
                    return true;
                }
            }
            position = -1;
            return false;
        }
    }

    public class SortedListArray : ListArray
    {
        public override void Add(Item item)
        {
            if (numItems == 0)
            {
                arrayOfItems[0] = item;
                numItems++;
            }
            else
            {
                int i = numItems - 1;
                while ((i != -1) && (string.Compare(arrayOfItems[i].ProductName, item.ProductName)>0))
                {
                    arrayOfItems[i + 1] = arrayOfItems[i];
                    i--;
                }
                arrayOfItems[i + 1] = item;
                numItems++;
            }
        }

        public override void RemoveAt(int index)
        {
            if (numItems >= index)
            {
                for (int i = numItems; i > index; i++)
                {
                    arrayOfItems[i] = arrayOfItems[i - 1];
                }
                numItems--;
            }
        }

        public override bool Remove(Item item)
        {
            int pos = 0;
            bool result = Found(item, out pos);
            if (result)
            {
                RemoveAt(pos);
            }
            return result;
        }

        public override bool Found(Item item, out int position)
        {
            int minNum = 0;
            int maxNum = numItems -1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (String.Compare(item.ProductName, arrayOfItems[mid].ProductName) == 0)
                {
                    position = mid--;
                    return true;
                }
                else if (String.Compare(item.ProductName, arrayOfItems[mid].ProductName) > 0)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            position = -1;
            return false ;
        }
    }
}
