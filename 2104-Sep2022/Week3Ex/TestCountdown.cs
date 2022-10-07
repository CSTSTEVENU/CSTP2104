using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week3Ex
{
    public class TestCountdown
    {
        public void BasicTest()
        {
            Countdown countdown = new Countdown(10);
            while(countdown.MoveNext())
            {
                Console.WriteLine("still continue");
            }
        }

        public void ResetTest()
        {
            Countdown countdown = new Countdown(10);
            while (countdown.MoveNext())
            {
                Console.WriteLine("still continue");
            }

            countdown.Reset();
            while (countdown.MoveNext())
            {
                Console.WriteLine("reset continue");
            }
        }

        public void UseLikeInterfaceTest()
        {
            IEnumerator countdown = new Countdown(10);
            while (countdown.MoveNext())
            {
                Console.WriteLine("with IEnumerator continue");
            }
        }
    }
}
