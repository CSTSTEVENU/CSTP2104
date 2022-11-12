using _2104_Sep2022.Week1Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment5
{
    public class ExamineTasks
    {
/*            public void SimpleTaskTest()
            {
                Console.WriteLine($"before the task {Thread.CurrentThread.ManagedThreadId}");
                Task task = Task.Run(() =>
                {
                    Console.WriteLine($"doing the task {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(2000);
                });
                Console.WriteLine($"after the task {Thread.CurrentThread.ManagedThreadId}");
                task.Wait(); // blocks until task is complete
            }*/

            public Employee Get(string id)
            {
                var e1 = new Developer("E001", StandardEmployeeType.Fulltime, 2019);

                return e1;
            }

            public async Task<Employee> GetAsync(string id)
            {
                var e1 = new Developer("E001", StandardEmployeeType.Fulltime, 2019);
                await Task.Delay(1000);

                return e1;
            }

            public async Task Add(Employee e)
            {
                await Task.Delay(1000);
            }
        }
    }

