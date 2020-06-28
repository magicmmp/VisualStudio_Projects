using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter4.Recipe6
{
	class Program
	{
		private static void Main(string[] args)
		{
			var cts = new CancellationTokenSource();
			var longTask = new Task<int>(() => TaskMethod("Task 1", 10, cts.Token), cts.Token);
			Console.WriteLine("任务状态1： "+longTask.Status);//Created
			cts.Cancel();
			Console.WriteLine("任务状态2： " + longTask.Status);//Canceled
			Console.WriteLine("First task has been cancelled before execution");
			cts = new CancellationTokenSource();
			longTask = new Task<int>(() => TaskMethod("Task 2", 10, cts.Token), cts.Token);
			longTask.Start();
			for (int i = 0; i < 5; i++ )
			{
				Thread.Sleep(TimeSpan.FromSeconds(0.5));
				Console.WriteLine("任务状态3： " + longTask.Status);//Running
			}
			cts.Cancel();
			for (int i = 0; i < 5; i++)
			{
				Thread.Sleep(TimeSpan.FromSeconds(0.5));
				Console.WriteLine("任务状态4： " + longTask.Status);//Running->RanToCompletion
			}

			Console.WriteLine("A task has been completed with result {0}.", longTask.Result);

			Console.ReadKey();
		}

		private static int TaskMethod(string name, int seconds, CancellationToken token)
		{
			Console.WriteLine("Task {0} is running on a thread id {1}. Is thread pool thread: {2}",
				name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsThreadPoolThread);
			for (int i = 0; i < seconds; i ++)
			{
				Thread.Sleep(TimeSpan.FromSeconds(1));
				if (token.IsCancellationRequested) return -1;
			}
			return 42*seconds;
		}
	}
}