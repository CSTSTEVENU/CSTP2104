using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week3Ex
{
    public class TestMember
    {
        public void BasicEqualityTest()
        {
            var m1 = new Member("U001", "Dan",
                "dan@hotmail.com", "M890");
            var m2 = new Member("U001", "Dan",
                "dan@hotmail.com", "M891");
            var m3 = new Member("U001", "Dan",
                "dan@hotmail.com", "M890");

            if(!m1.Equals(m2))
            {
                Console.WriteLine("m1 is not equal to m2");
            }

            if (m1.Equals(m3))
            {
                Console.WriteLine("m1 is equal to m3");
            }
        }
    }
}
