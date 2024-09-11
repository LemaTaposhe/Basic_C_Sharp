using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiTaskAsync_01
{
    internal class Program
    {
        private static void CreateTaskUsingAction()
        {
            Console.WriteLine("This task is created Using Action.");
        }
        private static void CreateTaskUsingDelegate()
        {
            Console.WriteLine("This Task is Created Task Using delegate ");
        }
        private static void CreateTaskUsingLambdaAdNamedMethod()
        {
            Console.WriteLine("This Task is created Using Lambda add name method.");
        }
        private static void CreateTaskUsingAsyncAwait()
        {
            Console.WriteLine("This task is created using Async Await.");
        }
        private static async void CreatedAsyncTask()
        { 
        await Task.Run(() =>CreatedAsyncTask());
        }
        private static int Add(int a, int b)
        { 
        return a + b;
        }
        private static async void SolveTheMath(int firstInt, int secondInt)
        {
            int result = await Task.FromResult(Add(firstInt, secondInt));
        }


        static async void Main(string[] args)
        {
            Console.WriteLine("Seven Ways To Start a Task in C#.Net");
            Console.WriteLine("========================");

            Task.Factory.StartNew(() => { Console.WriteLine("This Task is created using Factory Method."); });

            Task actionTask = new Task(new Action(CreateTaskUsingAction));
            actionTask.Wait(3000);
            actionTask.Start();

            Task delegateTask = new Task(delegate { CreateTaskUsingDelegate(); });
            delegateTask.Wait(2000);
            delegateTask.Start();


            Task lembdaAndNamedMethodTask = new Task(() => CreateTaskUsingLambdaAdNamedMethod());
            lembdaAndNamedMethodTask.Wait(2000);
            lembdaAndNamedMethodTask.Start();

            Task lembdaAndAnonymousMethodTask = new Task(() => CreateTaskUsingLambdaAdNamedMethod());
            lembdaAndAnonymousMethodTask.Wait(2000);
            lembdaAndAnonymousMethodTask.Start();

            CreatedAsyncTask();
            await Console.Out.WriteLineAsync("First No.: ");
            int fn=int.Parse(Console.ReadLine());
            await Console.Out.WriteLineAsync("Second No.:");
            int sn=int.Parse(Console.ReadLine());
            SolveTheMath(fn,sn);
            Console.ReadKey();
        }
    }
}
