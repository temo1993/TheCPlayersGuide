using System;
using System.Threading;

namespace TheCPlayersGuide
{
    public class ThreadTest
    {
        public static void Main_(string[] args)
        {
            Thread thread = new Thread(CountTo100);
            thread.Start();
//            To have the original thread wait at some point for this new thread to terminate, we use the Join
//            method:
            thread.Join();

            Thread thread1 = new Thread(CountTo100);
            thread1.Start();
            Thread thread2 = new Thread(CountTo100);
            thread2.Start();
            thread1.Join();
            thread2.Join();
            //            To make the current thread sleep, you can call the static Sleep method in the
            //            Thread class:
            //            Thread.Sleep(1000);
            Thread thread3 = new Thread(CountToNumber);
            thread3.Start(50);
        }

        //here is some code that runs two threads and waits for them to finish:

        public static void CountTo100()
        {
            for (int index = 0; index < 100; index++)
                Console.WriteLine(index + 1);
        }

        public static void CountToNumber(object input)
        {
            int n = (int)input;
            for (int index = 0; index < n; index++)
                Console.WriteLine(index + 1);
        }
    }
}

namespace Threading
{
    public class DivisionProblem
    {
        public double Dividend { get; set; } // the top
        public double Divisor { get; set; } // the bottom
        public double Quotient { get; set; } // the result (normally would be returned)
    }
    class Program
    {
        static void Main_(string[] args)
        {
            Thread thread = new Thread(Divide);
            DivisionProblem problem = new DivisionProblem
            {
                Dividend = 8,
                Divisor = 2
            };
            thread.Start(problem);
            thread.Join();
            Console.WriteLine("Result: " + problem.Quotient);
            Console.ReadKey();
        }
        public static void Divide(object input)
        {
            DivisionProblem problem = (DivisionProblem)input;
            problem.Quotient = problem.Dividend / problem.Divisor;
        }
    }
}