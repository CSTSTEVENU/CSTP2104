using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment4
{
    public class MyList<T> : IEnumerable<T>
    {
        T[] list_Items = null;
        int Index = 0;

        public MyList()
        {
            list_Items = new T[100];
        }

        public void Add(T item)
        {
            list_Items[Index] = item;
            Index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T type in list_Items)
            {
                if (type == null)
                {
                    break;
                }
                yield return type;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
