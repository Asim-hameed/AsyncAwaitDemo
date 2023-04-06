using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void task1()
        {
            Console.WriteLine("Task 1 starting....");
            Thread.Sleep(1000);
        }
    }
}
