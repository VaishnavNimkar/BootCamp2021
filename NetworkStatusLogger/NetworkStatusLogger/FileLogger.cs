using System;

namespace NetworkStatusLogger
{
    public class FileLogger : ILogger
    {
        public void WriteLogContent(string content) 
        { 
            Console.WriteLine("FileLogger " + content); 
        }
    }
}
