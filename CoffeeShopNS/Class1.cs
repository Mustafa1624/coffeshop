using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopNS
{
    public class CoffeeShop
    {
        private string p_name;
        private double m_balance;
        public const string PriceExceedsTheAmount = "Price exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Price less than zero";
        private bool m_frozen = false;
        private CoffeeShop()
        {
        }
        public CoffeeShop(string customerName, double balance)
        {
            p_name = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return p_name; }
        }
        public double Balance
        {
            get { return m_balance; }
        }
        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
        }
        public void pay(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }


            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, PriceExceedsTheAmount);
            }
            try
            {//ALL CODE
                if (amount < 0)
                {
                    
                }

            }
            catch (ArgumentOutOfRangeException)
            {

                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount;
        }
        public void Amountavailable(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount;
        }

        private void FreezeAccount()
        {
            m_frozen = true;
        }
        private void UnfreezeAccount()
        {
            m_frozen = false;
        }
        public static void Main()
        {
            CoffeeShop cShop = new CoffeeShop("Mr. Mustafa", 80.00);
            cShop.Amountavailable(5.77);
            cShop.pay(11.22);
            Console.WriteLine("Current balance is ${0}", cShop.Balance);
        }

    } 
    


}

