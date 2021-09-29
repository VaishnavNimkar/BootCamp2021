using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TransactionLogWriter _logger = new TransactionLogWriter();
            Action<string, TransactionStatus, string> _funObj = new Action<string, TransactionStatus, string>(_logger.WriteLog);

            Account _account = new Account();
            _account.AccountNumber = "44001123456";
            _account.Balance = 1000;
            _account.MinBalance = 500;

            Transaction _tx = new Transaction();
            _tx.Add_OnCompleted(_funObj);

            _tx.Deposit(_account, 1000);
            _tx.WithDraw(_account, 1000);
            _tx.WithDraw(_account, 600);

            Console.ReadKey();
        }
    }
}
