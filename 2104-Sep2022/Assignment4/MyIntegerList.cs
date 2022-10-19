using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment4
{
    public class MyIntegerList
    {
            private int year;
            private int grade;
            public MyIntegerList(int Grade, int Year)
            {
                grade = Grade;
                year = Year;
            }
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public int Grade
            {
                get { return grade; }
                set { grade = value; }
            }
        }//end class
    }//end namespace

