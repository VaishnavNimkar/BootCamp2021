using System;
using System.Threading.Tasks;

namespace WindowsUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SearchWindow searchWindow = new SearchWindow();
            while (true)
            {
                Console.WriteLine("Press Any Key To Click Clear Button");
                Console.Read();
                Task.Delay(3000).Wait();
                searchWindow.SimulateClearButtonClick();
            }
        }
    }
}
