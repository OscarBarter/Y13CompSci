using System;

namespace QueueTest
{
    public class AQueue<T>
    {
        private int capacity;
        public T[] QueueArray;
        private int rear;
        private int front;
        private int count;
        public int Count { get { return count; } }

        public AQueue() : this(capacity: 8)
        {
        }

        public AQueue(int capacity)
        {
            QueueArray = new T[capacity];
            this.capacity = capacity;
            rear = -1;
            front = 0;
            count = 0;
        }

        public void Enqueue(T s)
        {
            if (!Full)
            {
                if (rear == capacity - 1)
                {
                    rear = -1;
                }
                rear++;
                QueueArray[rear] = s;
                count++;
            }
            else
            {
                throw new InvalidOperationException("Invalid operation. The queue is full.");
            }
        }

        public T Dequeue()
        {
            if (!Empty)
            {
                T r = QueueArray[front];
                if (front == capacity - 1)
                {
                    front = -1;
                }
                front++;
                count--;
                return r;
            }
            else
            {
                throw new InvalidOperationException("Invalid operation. The queue is empty.");
            }
        }

        public bool Empty => count == 0;  // Empty implemented as a property

        public bool Full => count == capacity; // Full implemented as a property
    }
}
