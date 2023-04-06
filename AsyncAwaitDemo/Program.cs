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
            task1();
            task2();
            task3();
            task4();
            Console.ReadLine();
        }
        public static async void task1()
        {
            await Task.Run(() => 
            {
                Console.WriteLine("Task 1 starting....");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 Completed");
            });
            
        }
        public static async void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 starting....");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 Completed");
            });
            
        }
        public static async void task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 starting....");
                Thread.Sleep(5000);
                Console.WriteLine("Task 3 Completed");
            });
            
        }
        public static async void task4()
        {
            await Task.Run(()=>
            {
                Console.WriteLine("Task 4 starting....");
                Thread.Sleep(1000);
                Console.WriteLine("Task 4 Completed");
            });
           
        }
    }
}
