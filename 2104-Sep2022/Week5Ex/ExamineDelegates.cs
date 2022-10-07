using System;
using System.Collections.Generic;
using System.Text;
using _2104_Sep2022.Week3Ex;

namespace _2104_Sep2022.Week5Ex
{
    public class ExamineDelegates
    {
        private string _currentKey = "current900";

        // A delegate is an object that knows how to call a method.
        delegate int Converter(int num);

        delegate string KeyRetriever();

        public void SimpleDelegate()
        {
            // creates an instance of the delegate
            Converter converter = MultiplyBySelf;

            var result = converter(5);
            Console.WriteLine($"result= {result}");

            converter = SquareArea;
            result = converter(3);
            Console.WriteLine($"result= {result}");

            KeyRetriever keyRetriever = GetKey;
            Console.WriteLine($"key={keyRetriever()}");

            var member = new Member("U001", "Tom", "tom@voo.com", "M009");
            keyRetriever = member.GetUserID;
            var memberID = keyRetriever();
            Console.WriteLine($"memberID={memberID}");

            // totally the same as just using keyRetriever(); 
            keyRetriever.Invoke(); 
        }

        public int MultiplyBySelf(int i)
        {
            return i * i;
        }

        public int SquareArea(int i)
        {
            return i * i;
        }

        public int GetMmberID(int userID)
        {
            return 5;
        }

        public string GetKey()
        {
            return this._currentKey;
        }
    }
}
