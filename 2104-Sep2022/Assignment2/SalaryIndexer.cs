using _2104_Sep2022.Generics;
using _2104_Sep2022.Week1Quiz;
using _2104_Sep2022.Week2Ex;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Assignment2
{
    public class SalaryIndexer<TKey, TSubKey, TValue> where TValue : Employee, ISalaryCalculator
    {
        TValue _currentValue;

        public TValue GetCurrent()
        {
            return this._currentValue;
        }

        public double GetSalary(TKey key, TSubKey subKey)
        {
            return GetCurrent().Calculate();
        }
    }
}
