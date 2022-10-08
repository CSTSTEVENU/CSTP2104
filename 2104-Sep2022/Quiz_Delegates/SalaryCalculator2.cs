using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Quiz_Delegates
{
    public class SalaryCalculator2
    {
        delegate double Converter(int num);
        
        public void SalaryDelegate()
        {
            Converter converter = multiplyBySalary;
        }

        public int addBySalary(int i)
        {
            return i + i;
        }

        public double multiplyBySalary(double i)
        {
            return i * i;
        }

        public string getString(string i)
        {
            return i;
        }
    }
}
