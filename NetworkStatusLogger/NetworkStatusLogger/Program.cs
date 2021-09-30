using System.Threading.Tasks;

namespace NetworkStatusLogger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILogger _logger = new ConsoleLogger();
            NetWorkConnection _connection = new NetWorkConnection(_logger);
            _connection.Connect();
            Task.Delay(3000).Wait();
            _connection.Open();
            Task.Delay(3000).Wait();

            _connection.Close();
            _connection.Open();
            Task.Delay(3000).Wait();
            _connection.DisConnnect();
        }
    }
}
