using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 使用任务执行基本操作
{
    class Program
    {
		static void Main(string[] args)
		{
			//TaskMethod("Main Thread Task");


			Task<string> task = CreateTask("Task 1");
			Console.WriteLine("1阻塞在哪里？");
			task.Start();
			Console.WriteLine("2阻塞在哪里？");
			string result = task.Result;//会在这里阻塞直到返回结果
			Console.WriteLine("3阻塞在哪里？");
			Console.WriteLine("Result is: {0}", result);


			/**
			task = CreateTask("Task 2");
			task.RunSynchronously();
			result = task.Result;
			Console.WriteLine("Result is: {0}", result);

			task = CreateTask("Task 3");
			Console.WriteLine(task.Status);
			task.Start();

			while (!task.IsCompleted)
			{
				Console.WriteLine(task.Status);
				Thread.Sleep(TimeSpan.FromSeconds(0.5));
			}

			Console.WriteLine(task.Status);
			result = task.Result;
			Console.WriteLine("Result is: {0}", result);
			*/
			Console.ReadKey();
		}

		static Task<string> CreateTask(string name)
		{
			return new Task<string>(() => TaskMethod(name));
		}

		static string TaskMethod(string name)
		{
			Console.WriteLine("Task {0} is running on a thread id {1}. Is thread pool thread: {2}",
				name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsThreadPoolThread);
			Thread.Sleep(TimeSpan.FromSeconds(10));
			return "呵呵 "+name;
		}
	}
}
