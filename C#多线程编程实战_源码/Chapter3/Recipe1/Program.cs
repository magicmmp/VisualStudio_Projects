using System;
using System.Threading;

namespace Chapter3.Recipe1
{
	class Program
	{
		static void Main(string[] args)
		{
			int threadId = 0;

			RunOnThreadPool poolDelegate = Test;

			var t = new Thread(() => Test(out threadId));
			t.Start();
			t.Join();

			Console.WriteLine("主线程里：线程id: {0}", threadId);

			IAsyncResult r = poolDelegate.BeginInvoke(out threadId, Callback, "一个异步调用的委托...");

			
			r.AsyncWaitHandle.WaitOne();

			string result = poolDelegate.EndInvoke(out threadId, r);//EndInvoke事实上会等待异步操作的完成

			Console.WriteLine("主线程里：线程池工作线程id: {0}", threadId);
			Console.WriteLine(result);

			Thread.Sleep(TimeSpan.FromSeconds(2));
			
			Console.ReadKey();
		}

		private delegate string RunOnThreadPool(out int threadId);

		private static void Callback(IAsyncResult ar)
		{
			Console.WriteLine("开始一个回调函数...");
			Console.WriteLine("传给回调函数的参数: {0}", ar.AsyncState);
			Console.WriteLine("Callback里：Is thread pool thread: {0}", Thread.CurrentThread.IsThreadPoolThread);
			Console.WriteLine("Callback里：Thread pool worker thread id: {0}", Thread.CurrentThread.ManagedThreadId);
		}


		private static string Test(out int threadId)
		{
			Console.WriteLine("子线程开始工作...");
			Console.WriteLine("子线程里:是否线程池的线程 {0}", Thread.CurrentThread.IsThreadPoolThread);
			Thread.Sleep(TimeSpan.FromSeconds(2));
			threadId = Thread.CurrentThread.ManagedThreadId;
			return string.Format("子线程返回:线程池工作线程id: {0}", threadId);
		}
	}
}
