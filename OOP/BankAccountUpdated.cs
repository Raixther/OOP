using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankAccountUpdated
    {
        private static int _idKey;

        public int _id { get; set; }

        public int _balance { get; set; }

        public BankAccountUpdated() => this._id = this.GenerateId();

        public BankAccountUpdated(int balance)
          : this()
        {
            this._balance = balance;
        }
        private int GenerateId()
        {
            int idKey = BankAccountUpdated._idKey;
            ++BankAccountUpdated._idKey;
            return idKey;
        }

        public void Transaction(BankAccountUpdated account, int transactionSum)
        {
            if (account._balance < transactionSum)
                return;
            this._balance += transactionSum;
            account._balance -= transactionSum;
        }

      
    }
}
