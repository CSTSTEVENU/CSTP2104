using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Generics
{
    public class ObjectStack
    {
        private int CurrentPosition;
        private object[] data;
        private int size;

        public ObjectStack(int size)
        {
            this.data = new object[size];
            this.CurrentPosition = 0;
            this.size = size;
        }

        public void Push(object number)
        {
            if (CurrentPosition >= size)
            {
                throw new InvalidOperationException("Out of Stack Memory");
            }
            data[CurrentPosition++] = number;
        }

        public object Pop()
        {
            if (CurrentPosition <= 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            return data[CurrentPosition--];
        }

        public int Count()
        {
            return CurrentPosition;
        }
    }
}
