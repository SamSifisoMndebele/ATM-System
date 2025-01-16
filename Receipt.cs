using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System
{
    internal class Receipt
    {
        string accountNo;
        double balance;
        double transBalance;
        double newBalance;
        bool isDeposit;
        bool isSuccessful;
        string errorMsg;

        public Receipt(string accountNo, double balance, double transBalance, double newBalance, bool isDeposit, bool isSuccessful, string errorMsg = null)
        {
            this.accountNo = accountNo;
            this.balance = balance;
            this.transBalance = transBalance;
            this.newBalance = newBalance;
            this.isDeposit = isDeposit;
            this.isSuccessful = isSuccessful;
            this.errorMsg = errorMsg;
        }

        public string AccountNo { get { return accountNo; } }
        public double Balance { get { return balance; } }
        public double TransBalance { get { return transBalance; } }
        public double NewBalance { get {return newBalance; } }
        public bool IsDeposit { get { return isDeposit; } }
        public bool IsSuccessful { get { return isSuccessful; } }
        public string ErrorMsg { get { return errorMsg; } }
    }
}
