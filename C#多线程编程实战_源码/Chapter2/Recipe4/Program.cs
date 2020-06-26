using System;
using System.Threading;

namespace Chapter2.Recipe4
{
	class Program
	{
		static void Main(string[] args)
		{
			var t = new Thread(() => Process(10));
			t.Start();

			Console.WriteLine("1、主线程说：等待子线程完成第 1 个工作。");
			_workerEvent.WaitOne();
			
			Console.WriteLine("5、主线程说：子线程完成第1个工作！");
			Console.WriteLine("6、主线程说：执行一个操作。");
			Thread.Sleep(TimeSpan.FromSeconds(5));
			_mainEvent.Set();
			Console.WriteLine("7、主线程说：等待子线程完成第 2 个工作。");
			_workerEvent.WaitOne();
			Console.WriteLine("10、主线程说：子线程完成第 2 个工作！");

			Console.ReadKey();
		}

		private static AutoResetEvent _workerEvent = new AutoResetEvent(false);
		private static AutoResetEvent _mainEvent = new AutoResetEvent(false);

		static void Process(int seconds)
		{
			Console.WriteLine("2、子线程说：我要开始运行第1个工作");
			Thread.Sleep(TimeSpan.FromSeconds(seconds));
			Console.WriteLine("3、子线程说：完成第1个工作了");
			_workerEvent.Set();
			
			Console.WriteLine("4、子线程说：我等待主线程执行一个操作");
			_mainEvent.WaitOne();
			Console.WriteLine("8、子线程说：我要开始运行第2个工作");
			Thread.Sleep(TimeSpan.FromSeconds(seconds));
			Console.WriteLine("9、子线程说：我完成了第2个工作");
			_workerEvent.Set();
		}
	}
}
