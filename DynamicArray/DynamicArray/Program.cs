using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
            DArray<int> intArray = new DArray<int>();
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[5] = 50;
            intArray.PrintArray();
            DArray<float> floatArray = new DArray<float>();
            floatArray[0] = 10.5F;
            floatArray[2] = 12.5F;
            floatArray[3] = 13.5F;
            floatArray[4] = 14.5F;
            floatArray.PrintArray();

            Console.ReadKey();
        }
	}
}
