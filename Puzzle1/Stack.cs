using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzle1
{
    public class Stack<T>
    {
#region Properties

        public int Capacity { get; private set; }

        public int Length
        {
            get { return Index + 1; }
        }

        protected T[] Elements { get; set; }

        private int _index = -1;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
#endregion

        public Stack(int capacity)
        {
            Capacity = capacity;
            Elements = new T[Capacity];
        }

        public void Push(T element)
        {
            if (this.Length == Capacity)
            {
                throw new InvalidOperationException("Stack is full");
            }
            Index++;
            Elements[Index] = element;
        }

        public T Pop()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T element = Elements[Index];
            Elements[Index] = default(T);
            Index--;
            return element;
        }

        public T Peek()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return Elements[Index];
        }
    }
}
