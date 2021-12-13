using System;

namespace Lesson6
{
	class Program
	{
		static void Main(string[] args)
		{
            BankAccount2 Q = new(200);

            BankAccount2 T = new(300);

            Console.WriteLine(Q.ToString());

            Console.WriteLine(Q.Equals(T));

            Console.WriteLine(Q==T);


            Console.WriteLine(Q != T);

            Console.WriteLine(Q.GetHashCode());

            Console.WriteLine(T.GetHashCode());


            Console.ReadKey();

        }
	}

    public sealed class BankAccount2
    {
        private static int _idKey;

        public int _id {get;}

        private int _balance { get; set; }

        public BankAccount2() => this._id = this.GenerateId();

        public BankAccount2(int balance):this()
        {
            this._balance = balance;
        }
        private int GenerateId()
        {
            int idKey = BankAccount2._idKey;
            ++BankAccount2._idKey;
            return idKey;
        }

        public void Transaction(BankAccount2 account, int transactionSum)
        {
            if (account._balance < transactionSum)
                return;
            this._balance += transactionSum;
            account._balance -= transactionSum;
        }
        public static bool operator ==(BankAccount2 A, BankAccount2 B)
		{
			if (A._balance == B._balance) return true;			
            return false;
		}
        public static bool operator !=(BankAccount2 A, BankAccount2 B)
        {
            if (A._balance != B._balance) return true;           
            return false;
        }

		public override bool Equals(object obj)
		{
            if (_balance == ((BankAccount2)obj)._balance) return true;
            return false;
        }

		public override int GetHashCode()
		{
            return _id.GetHashCode();      
		}

		public override string ToString()
		{
            return _id.ToString()+" "+_balance.ToString();
		}
	}

}

