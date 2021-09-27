using System;

namespace StackImplementation
{
	public class Stack
	{
		int top = -1;
		int[] arr = new int[5];

		public void Push(int num)
		{
			if (top < 4)
				arr[++top] = num;
			else
				Console.WriteLine("Stack Overflow");
		}

		public int Pop()
		{
			if (top < 0)
			{
				Console.WriteLine("Stack Underflow");
				return -1;
			}


			int temp = 0;
			temp = arr[top--];
			arr[top+1] = 0;
			return temp;
		}

		public void Print()
		{
			Console.WriteLine(String.Join(" ", arr));
		}

		public void Clear()
		{
			arr = new int[5];
		}
	}
}
