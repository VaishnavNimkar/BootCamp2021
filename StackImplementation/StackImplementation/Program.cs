using System;

namespace StackImplementation
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Stack stk = new Stack();
			stk.Push(10);
			stk.Push(20);
			stk.Push(30);
			stk.Push(40);
			Console.WriteLine("Popped item = " + stk.Pop());
			stk.Print();
			stk.Clear();
			stk.Print();
			Console.ReadKey();
		}
	}
}
