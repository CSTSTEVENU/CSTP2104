using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Generics
{
    public class IntegerStack
    {
        private int CurrentPosition;
        private int[] data;
        private int size;
        
        public IntegerStack(int size)
        {
            this.data = new int[size];
            this.CurrentPosition = 0;
            this.size = size;
        }

        public void Push(int number)
        {
            if (CurrentPosition >= size)
            {
                throw new InvalidOperationException("Out of Stack Memory");
            }
            data[CurrentPosition++] = number;
        }

        public int Pop()
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
