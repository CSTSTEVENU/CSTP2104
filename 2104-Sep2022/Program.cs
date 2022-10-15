using _2104_Sep2022.Assignment_3;
using _2104_Sep2022.Generics;
using _2104_Sep2022.Week1Ex;
using _2104_Sep2022.Week1Quiz;
using _2104_Sep2022.Week2Ex;
using _2104_Sep2022.Week5Ex;
using System;
using System.Collections.Generic;
using static _2104_Sep2022.Assignment_3.SalaryCalculator2;

namespace _2104_Sep2022
{
    class Program
    {
        static void Main(string[] args)
        {

            // Assignment 3

            EmployeePayroll e1 = new EmployeePayroll("M001", 23, 50);
            EmployeePayroll e2 = new EmployeePayroll("S001", 40, 40);
            EmployeePayroll e3 = new EmployeePayroll("M002", 38, 52.50);
            EmployeePayroll e4 = new EmployeePayroll("S011", 23, 43.50);
            EmployeePayroll e5 = new EmployeePayroll("M023", 34, 42);

            
            SalaryDelegate salaryCalculator = SalaryCalculator2.CalculateSalary;
            EmployeePayroll[] employees = { e1, e2, e3, e4, e5 };

            foreach(EmployeePayroll employed in employees)
            {
                var payField = salaryCalculator(employed.ID, employed.Hours, employed.Rate,employed.Pay);
                employed.Pay = payField;

                Console.WriteLine("Employee Name: " + employed.ID + "Employee Hours: " + employed.Hours + "Employee Rate: " + employed.Rate + "Employee Pay: " + employed.Pay);

            }


            /*var examineDelegate = new ExamineDelegates();
            examineDelegate.CalculateAreaUsingGenericDelegate();
            examineDelegate.CalculateAreaUsingGenericDelegate2();*/

            // examineDelegate.MulticastDelegateExample2();

            // examineDelegate.CalculateSquareAreasExample();

            // Static method
            // ExamineDelegates.CalculateSquareArea(4);

            /// examineDelegate.SimpleDelegate();
        }

        //    var examineDelegate = new ExamineDelegates();
        //    examineDelegate.SimpleDelegate();

        //    // new TestMember().BasicEqualityTest();
        //     new Program().TestNonGenericStack();
        //    new Program().TestGenericStack();
        //    // interface example
        //    // new TestCountdown().BasicTest();
        //    // new TestCountdown().ResetTest();
        //    // new TestCountdown().UseLikeInterfaceTest();

        //    // new Program().TestPolymorphicFunction();
        //    // new Program().TestCasting();
        //    // new Program().TestVirtualFunc();
        //

        private void TestRunGenericFunctions()
        {
            var arrInt = new int[] { 5, 6, 7 };
            var arrStr = new string[] { "aaa", "bbb", "ccc" };
            var arrEmployee = new Developer[]
            {
                new Developer("I290", StandardEmployeeType.Parttime, 2020),
                new Developer("I450", StandardEmployeeType.Parttime, 2021)
            };

            Program.Reset<Developer>(arrEmployee);
            Program.Reset<int>(arrInt);
            Program.Reset<string>(arrStr);

            arrEmployee = new Developer[]
            {
                new    Developer("I290", StandardEmployeeType.Parttime, 2020),
                new Developer("I450", StandardEmployeeType.Parttime, 2021)
            };

            Program.Reset<Employee>(arrEmployee);

            //var a = "strA";
            //var b = "strB";
            //Program.Swap(a, b);
            //Console.WriteLine($"After swap str a={a} b={b}");

            //int a1 = 5;
            //int b1 = 10;
            //Program.Swap(a1, b1);
            //Console.WriteLine($"After swap1 a1={a1} b1={b1}");

            //int a2 = 5;
            //int b2 = 10;
            //Program.Swap(ref a2, ref b2);
            //Console.WriteLine($"After swap2 a2={a2} b2={b2}");

            //int a3 = 5;
            //int b3 = 10;
            //Program.Swap<int>(ref a3, ref b3);
            //Console.WriteLine($"After swap<int> a2={a3} b2={b3}");

            //var s1 = "strA";
            //var s2 = "strB";
            //Program.Swap<string>(ref s1, ref s2);
            //Console.WriteLine($"After swap<string> s1={s1} s2={s2}");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            Dictionary<string, GenericStack<Employee>> stackDict = new Dictionary<string, GenericStack<Employee>>();

            Indexer<string, string, Developer> indexer = new Indexer<string, string, Developer>();
            Indexer<string, string, ProjectManager> indexer2 = new Indexer<string, string, ProjectManager>();

        }

        /// <summary>
        /// Generics gets rid of all these copies of the same
        /// function which differ only by the type of the input parameter
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(string a, string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Generic swap function can accept any type and successfully do the swap
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Another example for usage of Generics
        /// </summary>
        /// <param name="arr"></param>
        private static void Reset(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }

        private static void Reset(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = null;
            }
        }

        private static void Reset(Developer[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = null;
            }
        }

        private static void Reset(Employee[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = null;
            }
        }

        private static void Reset<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = default(T);
            }
        }

        public void TestNonGenericStack()
        {
            var intStack = new IntegerStack(2);
            intStack.Push(2);
            var i = intStack.Pop();

            var objStack = new ObjectStack(2);
            objStack.Push("string");
            objStack.Push(i);

            int i2 = (int)objStack.Pop();
        }

        public void TestGenericStack()
        {
            var genericStack = new GenericStack<string>(10);
            genericStack.Push("hello");
            genericStack.Push("stack");

            var genericStack2 = new GenericStack<Employee>(10);
            genericStack2.Push(new Developer("D001", StandardEmployeeType.Fulltime, 2019));

            var genericStack3 = new GenericStack<int>(10);
            genericStack3.Push(456);
        }

        private void TestPolymorphicFunction()
        {
            var p1 = new ProjectManager("PM001");
            var d1 = new Developer("Dev001", StandardEmployeeType.Fulltime, 2019);
            var devops1 = new DevOpsEngineer("DevOps001", StandardEmployeeType.Fulltime, 2018);

            DisplayUtility.DisplayProperties(d1);
            DisplayUtility.DisplayProperties(devops1);
            // DisplayProperties(p1); // compile error

            d1.Display();
            devops1.Display();
        }

        private void TestCasting()
        {
            // 1 - Implicit casting - upcast to a base reference
            // 2 - Explicit downcast to a subclass
            // ==============================================

            var d1 = new Developer("Dev001", StandardEmployeeType.Fulltime, 2019);
            Employee employee = d1;  // implicit upcast
            Console.WriteLine(d1.GetVacationDays());
            // Console.WriteLine(se.VacationDays); // compile error

            // explicit downcast
            Developer d2 = (Developer)employee;
            // explicit downcast - runtime error! - will not work InvalidCastException thrown
            // ProjectManager p1 = (ProjectManager)se; // downcast fails se is not a ProjectManager

            // The as Operator - also performs a downcast but it does so silently
            Developer d3 = employee as Developer;
            ProjectManager p2 = employee as ProjectManager;
            if (p2 == null)
            {
                Console.WriteLine("se can't be converted to p2 ");
            }

            var pm1 = new ProjectManager("PJ001");
            Employee employee2 = pm1;

            // The is operator - tests whether a variable matches a pattern
            if (employee2 is ProjectManager)
            {
                Console.WriteLine( ((ProjectManager)employee2).HourlyRate);

                // ((ProjectManager)employee).HourlyRate in multiple lines
                var pm = (ProjectManager)employee2;
                var rate = pm.HourlyRate;
            }

            // primitive object cast etc.
            //string s1 = "2";
            //int i = Convert.ToInt32(s1);

            // this is an abstract class - build error!
            // var standEmp = new StandardEmployee();
        }

        private void TestVirtualFunc()
        {
            var d1 = new Developer("Dev011", StandardEmployeeType.Fulltime, 2014);
            var d2 = new Developer("Dev012", StandardEmployeeType.Fulltime, 2019);
            var d3 = new Developer("Dev023", StandardEmployeeType.Fulltime, 2022);
            var devops1 = new DevOpsEngineer("DevOps001", StandardEmployeeType.Fulltime, 2011);
            var devops2 = new DevOpsEngineer("DevOps004", StandardEmployeeType.Fulltime, 2018);
            var productManager = new ProductManager("ProdMan001", StandardEmployeeType.Fulltime, 2011);

            var standardEmployees = new List<StandardEmployee>();
            standardEmployees.Add(d1);
            standardEmployees.Add(d2);
            standardEmployees.Add(d3);
            standardEmployees.Add(devops1);
            standardEmployees.Add(devops2);
            standardEmployees.Add(productManager);

            foreach(var standardEmployee in standardEmployees)
            {
                DisplayUtility.DisplayProperties(standardEmployee);
            }
        }
    }
}
