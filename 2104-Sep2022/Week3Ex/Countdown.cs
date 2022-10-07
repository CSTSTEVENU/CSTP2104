using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week3Ex
{
    public class Countdown : IEnumerator
    {
        private int count;
        private int initialCount;

        public Countdown(int count)
        {
            this.count = count;
            this.initialCount = count;
        }

        // this is exactly the same as writing a get
        // public object Current => count;

        public object Current
        {
            get
            {
                return count;
            }
        }

        public bool MoveNext()
        {
            if (count-- > 0)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            this.count = initialCount;       
        }
    }
}
