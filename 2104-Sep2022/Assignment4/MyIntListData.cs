using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment4
{
    public class MyIntListData : IEnumerator, IEnumerable
    {
        private MyIntegerList[] numlist;
        int position = -1;
        //Create internal array in constructor.
        public MyIntListData()
        {
            numlist = new MyIntegerList[6]
            {
               new MyIntegerList(8,1998),
               new MyIntegerList(12,1992),
               new MyIntegerList(3,1993),
               new MyIntegerList(1,1996),
               new MyIntegerList(9,1995),
               new MyIntegerList(7,2007)
            };
        }
        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < numlist.Length);
        }
        //IEnumerable
        public void Reset()
        {
            position = -1;
        }
        //IEnumerable
        public object Current
        {
            get { return numlist[position]; }
        }
    }
}

