using _2104_Sep2022.Week1Quiz;
using _2104_Sep2022.Week2Ex;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Generics
{
    /// <summary>
    /// you can add a class and an interface to the constraints
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TSubKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class Indexer<TKey, TSubKey, TValue> where TValue : Employee , ISalaryCalculator
    {
        private TValue _currentValue;
        private int _index;
        public int Count;

        public void Add(TKey key, TSubKey subKey, TValue value)
        {
            
        }

        public TValue GetCurrent()
        {
            return this._currentValue;
        }

        public double GetSalary(TKey key, TSubKey subKey)
        {
            return _currentValue.Calculate();
        }
    }
}
