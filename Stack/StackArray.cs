using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace Stack
{
    public class StackArray<T>
    {
        private int capacity;
        private T[] arrayStack;
        private int top;
        public int Count { get { return top + 1; } }

        public StackArray() : this(capacity: 100)
        {
        }

        public StackArray(int capacity)
        {
            arrayStack = new T[capacity];
            this.capacity = capacity;
            top = -1;
        }

        public void Push(T s)
        {
            top++;
            arrayStack[top] = s;
        }


        public T Pop()
        {
            T r = arrayStack[top];
            top--;
            return r;
        }

        public T Peek()
        {
            return arrayStack[top];
        }

        public void Clear()
        {
            top = -1;
        }

        public bool Empty()
        {
            return top == -1;
        }

        public bool Full()
        {
            return (top + 1) == capacity;
        }

    }
}
