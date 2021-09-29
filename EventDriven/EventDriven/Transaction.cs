using System;

namespace EventDriven
{
    class Transaction
    {
        TransactionStatus status;

        Action<string, TransactionStatus, string> OnCompleted;

        public void Add_OnCompleted(Action<string, TransactionStatus, string> handler)
        {
            OnCompleted += handler;
        }

        public void Remove_OnCompleted(Action<string, TransactionStatus, string> handler)
        {
            OnCompleted -= handler;
        }

        public void Deposit(Account account, decimal amt)
        {

            account.Balance += amt;
            ChangeTransactionStatus("Deposit", TransactionStatus.SUCCESS, account.AccountNumber);

        }

        public void WithDraw(Account account, decimal amt)
        {

            if ((account.Balance - amt) < account.MinBalance)
            {
                ChangeTransactionStatus("WithDraw", TransactionStatus.FAILURE, account.AccountNumber);
            }
            else
            {
                account.Balance -= amt;
                ChangeTransactionStatus("WithDraw", TransactionStatus.SUCCESS, account.AccountNumber);
            }

        }

        private void ChangeTransactionStatus(string transactionType, TransactionStatus status, string accountNumber)
        {

            this.status = status;
            if (this.OnCompleted != null)
            {

                //Raise
                this.OnCompleted.Invoke(transactionType, status, accountNumber);
            }
        }

    }
}
