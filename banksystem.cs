using System;
using System.Collections.Generic;
using System.Text;

namespace LabDay5
{
    class Account
    {
        public Account(String n)
        {
            Name = n;
            
        }
        protected Guid Accoutn_id;
        protected string Name;
        protected int Balance;

        protected void Create_Account(int b)
        {
            Balance = b;
        }


    }
    class Saving_Account:Account
    {
        public Saving_Account(string name,int initial_balance): base(name)
        {
            Accoutn_id = Guid.NewGuid();
            Create_Account(initial_balance);

        }

        public void Credit(int balance)
        {
            if (Accoutn_id != null)
            {
                Console.WriteLine($"your old  balance is :{Balance}");
                balance = Balance + balance;
                Balance = balance;
                Console.WriteLine($"your new balance is :{Balance}");
            }
            else
            {
                Console.WriteLine("please register first");
            }

        }
        public void Debit(int balance)
        {
            if (Accoutn_id != null)
            {
                if (balance > Convert.ToInt32(Balance))
                {
                    Console.WriteLine("the money that take is greater than the avilable");
                }
                else
                {
                    Balance = Balance - balance;
                    Console.WriteLine($"your new balance is :{Balance}");
                }
            }
            else
            {
                Console.WriteLine("please register first");
            }
        }
    }
}