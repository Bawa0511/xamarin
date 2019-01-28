using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Bank b = new Bank();
            do
            {
                Console.WriteLine("enter your choice\n 1.Balance\n 2.Deposit \n3.withdraw");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        b.cheakBalance();
                        break;
                    case 2:
                        b.deposit();
                        break;
                    case 3:
                        b.withdraw();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            } while (ch != 0);
            Console.ReadKey();
        }
    }
}





class [bank.cs]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Bank
    {
        public float balAmount;
        public string accNumber;
        public float amount;
        public Bank()
        {
            balAmount = 5000;
        }
        public void cheakBalance()
        {
            Console.WriteLine("Balance=" + balAmount);
        }
        public void deposit()
        {
            Console.WriteLine("enter amount for deposit");
            amount = float.Parse(Console.ReadLine());
            balAmount += amount;
        }
        public void withdraw()
        {
            float minbal;
            Console.WriteLine("enter amount for withdraw");
            amount = float.Parse(Console.ReadLine());
            minbal = balAmount - 5000;
            if(amount<minbal)
            {
                balAmount -= amount;
            }
            else if(amount>minbal)
            {
                Console.WriteLine("not sufficient balance");
            }
        }
    }
}
