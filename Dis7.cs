using System;
using System.Threading;
using System.Threading.Tasks;

namespace eksamen
{
	public class Dis7
	{
		public static async Task Dis7Main()
		{
            Task task1 = new Task(() =>
            {
                Console.WriteLine("Task 1 er i gang." + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                Console.WriteLine("Task 1 er færdig." + Thread.CurrentThread.ManagedThreadId);
            });
            Task task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 er i gang." + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);
                Console.WriteLine("Task 2 er færdig." + Thread.CurrentThread.ManagedThreadId);
            });
            Task task3 = new Task(DoWork);
            task1.Start();
            task2.Start();
            task3.Start();

            Task.WaitAll(task1, task2, task3);
            Console.WriteLine("Alle tasks er fuldført." + Thread.CurrentThread.ManagedThreadId);

            await HandlingAsync();

            Console.WriteLine("Method done.");

        }
        public static void DoWork()
        {
            Console.WriteLine("Task 1 er i gang.");
            Thread.Sleep(1000);
            Console.WriteLine("Task 1 er færdig.");
        }

        public static async Task HandlingAsync()
        {
            Console.WriteLine("Starting async operation...");

            // Simulate an asynchronous operation
            await Task.Delay(2000);

            Console.WriteLine("Async operation completed.");
        
        }
    }
}

