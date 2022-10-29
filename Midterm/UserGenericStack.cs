using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class UserGenericStack<T>
    {
        private int stackPosition;
        private T[] stackData;
        private int size;

        public UserGenericStack(int size)
        {
            this.stackData = new T[size];
            this.stackPosition = 0;
            this.size = size;
        }

        public void Push(T number)
        {
            if (stackPosition >= size)
            {
                throw new InvalidOperationException("Removed out of Stack");
            }
            stackData[stackPosition++] = number;
        }

        public object Pop(StandardUser standardUser)
        {
            if (stackPosition <= 0)
            {
                throw new InvalidOperationException("Nothing in stack");
            }

            return stackData[stackPosition--];
        }

        public object Pop(Manager manager)
        {
            if (stackPosition <= 0)
            {
                throw new InvalidOperationException("Nothing in stack");
            }

            return stackData[stackPosition--];
        }

        public object Pop(Owner owner)
        {
            if (stackPosition <= 0)
            {
                throw new InvalidOperationException("Nothing in stack");
            }

            return stackData[stackPosition--];
        }

        public object Pop(Administrator administrator)
        {
            if (stackPosition <= 0)
            {
                throw new InvalidOperationException("Nothing in stack");
            }

            return stackData[stackPosition--];
        }

        public int Count()
        {
            return stackPosition;
        }
    }
}
