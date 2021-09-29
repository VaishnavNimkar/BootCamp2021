using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven
{
    public class TransactionLogWriter
    {
        public void WriteLog(string transactionType, TransactionStatus status, string accountNumber)
        {

            Console.WriteLine("TransactionType:{0},TransactionStatus:{1},AccountNumber:{2}", transactionType, status, accountNumber);
        }
    }
}
