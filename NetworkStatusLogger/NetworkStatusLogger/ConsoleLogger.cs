using System;

namespace NetworkStatusLogger
{
    public class ConsoleLogger : ILogger
    {
        public void WriteLogContent(string content)
        {
            Console.WriteLine(content);
        }
    }
}
