using System;

namespace DynamicArray
{
	public class DArray<T>
	{
        private T[] buffer = new T[5];
        private int itemCount;
        public T this[int index]
        {
            set
            {
                if (index >= buffer.Length)
                {
                    Array.Resize(ref buffer, index + 1);
                }

                buffer[index] = value;
                itemCount++;
            }
            get
            {
                return buffer[index];
            }
        }

        public void PrintArray()
        {
            Console.WriteLine(String.Join(" ", buffer));
        }
    }
}
