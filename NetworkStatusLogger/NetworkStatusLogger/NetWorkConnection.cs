namespace NetworkStatusLogger
{
    public class NetWorkConnection
    {
        ILogger _logger;

        public NetWorkConnection(ILogger logger)
        {
            this._logger = logger;
        }
        public void Open()
        {
            _logger.WriteLogContent(string.Format("NetworkConnection Opened at:{0}", System.DateTime.Now));
        }

        public void Connect()
        {
            _logger.WriteLogContent(string.Format("NetworkConnection Connected at:{0}", System.DateTime.Now));
        }

        public void DisConnnect()
        {

            _logger.WriteLogContent(string.Format("NetworkConnection Disconnected at:{0}", System.DateTime.Now));
        }
        public void Close()
        {

            _logger.WriteLogContent(string.Format("NetworkConnection Closed at:{0}", System.DateTime.Now));
        }
    }
}
