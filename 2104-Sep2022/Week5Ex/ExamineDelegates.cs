using System;
using System.Collections.Generic;
using System.Text;
using _2104_Sep2022.Week3Ex;

using static _2104_Sep2022.Week5Ex.DiskCleanupUtility;

namespace _2104_Sep2022.Week5Ex
{
    public class ExamineDelegates
    {
        private string _currentKey = "current900";

        // A delegate is an object that knows how to call a method.
        public delegate int Converter(int num);

        // generic delegate
        public delegate T Transformer<T>(T arg);

        delegate string KeyRetriever();

        public static int CalculateSquareArea(int i)
        {
            Console.WriteLine($"CalculateSquareArea: calculating for {i}");
            return i * i;
        }

        public void ExamineFuncs()
        {
            Func<int, int> f;
        }

        public void SimpleDelegate()
        {
            // creates an instance of the delegate
            Converter converter = MultiplyBySelfFunc;

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

            /// this is the same as just using keyRetriever();
            keyRetriever.Invoke();
        }

        public void MulticastDelegateExample()
        {
            Converter converter = SquareArea;
            converter += MultiplyBySelfFunc; // adds a function from the list of functions within the delegate
            converter -= MultiplyBySelfFunc; // removes a function from the list of functions within the delegate
        }

        public void MulticastDelegateExample2()
        {
            var diskCleanupUtility = new DiskCleanupUtility();
            var progressReporter = new ProgressReporter("progress.txt");
            Reporter reporter = progressReporter.WriteProgressToConsole;
            reporter += progressReporter.WriteProgressToFile;

            diskCleanupUtility.Cleanup(10, reporter);
        }

        public void CalculateSquareAreasExample()
        {
            int[] squareSides = { 2, 4, 6, 8 };
            int[] areas = this.CalculateAreas(squareSides, SquareArea);

            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"First run results: area[{i}] = {areas[i]}");
            }

            areas = this.CalculateAreas(squareSides, MultiplyBySelfFunc);

            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Second run results: area[{i}] = {areas[i]}");
            }

            areas = this.CalculateAreas(squareSides, CalculateSquareArea);

            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Third run results: area[{i}] = {areas[i]}");
            }
        }

        public void CalculateAreaUsingGenericDelegate()
        {
            int[] squareSides = { 2, 4, 6, 8 };
            int[] areas = this.Transform<int>(squareSides, SquareArea);

            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Run with Generic delegate results: area[{i}] = {areas[i]}");
            }
        }

        public T[] Transform<T>(T[] values, Transformer<T> transformer)
        {
            T[] results = new T[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                results[i] = transformer(values[i]);
            }

            return results;
        }

        public void CalculateAreaUsingGenericDelegate2()
        {
            int[] squareSides = { 2, 4, 6, 8 };
            int[] areas = this.Transform2<int>(squareSides, SquareArea);

            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Run with Func delegate results: area[{i}] = {areas[i]}");
            }
        }

        public T[] Transform2<T>(T[] values, Func<T, T> transformer)
        {
            T[] results = new T[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                results[i] = transformer(values[i]);
            }

            return results;
        }

        public int[] CalculateAreas(int[] sides, Converter areaCalculator)
        {
            int[] areas = new int[sides.Length];

            for (int i = 0; i < sides.Length; i++)
            {
                areas[i] = areaCalculator(sides[i]);
            }

            return areas;
        }

        public void DiaplayValues(int[] values, string messageTemplate)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"Third run results: area[{i}] = {values[i]}");
            }

        }

        public int[] CalculateAreas2(int[] sides)
        {
            int[] areas = new int[sides.Length];

            for (int i = 0; i < sides.Length; i++)
            {
                areas[i] = SquareArea(sides[i]);
            }

            return areas;
        }

        public int SquareArea(int i)
        {
            Console.WriteLine($"SquareArea: calculating for {i}");
            return i * i;
        }

        public int MultiplyBySelfFunc(int i)
        {
            Console.WriteLine($"MultiplyBySelfFunc: calculating for {i}");
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
