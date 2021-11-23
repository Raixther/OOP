using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankAccount
    {
        private int _id;

        private int _balance;
   
        public int GetId() => this._id;

        public int GetBalance() => this._balance;

   

        public void SetId(int id) => this._id = id;

        public void SetBalance(int balance) => this._balance = balance;

    }
}
