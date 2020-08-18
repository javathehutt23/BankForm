using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankForm
{
    abstract class Account
    {
        public Customer customerId;
        public float Deposit(float Balance, float DepositAmount)
        {
            float newBalance = Balance + DepositAmount;
            return newBalance;
        }

        public abstract void Withdraw(float withdrawAmount);
        public abstract void CalculateInterest();
        public abstract string CheckBalance();
    }

    class EverydayAccount : Account
    {
        private int accountId;
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        private string accountType;
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public override string CheckBalance(){
            Console.WriteLine("the balance is: $" + Balance);
            string a = AccountType + " " + AccountId + "; balance $" + Balance;
            return a;
        }
        public override void Withdraw(float withdrawAmount) { Console.WriteLine("Withdrawals aren't authorised for this type of account"); }
        public override void CalculateInterest() { Console.WriteLine("Interest isn't authorised for this type of account"); }

    }
    class InvestmentAccount : Account
    {
        private int accountId;
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        private string accountType;
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private float interestRate;
        public float InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        private float fees;
        public float Fees
        {
            get { return fees; }
            set { fees = value; }
        }
        public override string CheckBalance()
        {
            Console.WriteLine("the balance is: $" + Balance);
            string a = AccountType + " " + AccountId + "; Fee $" + Fees + "; balance $" + Balance;
            return a;
        }
        public override void Withdraw(float withdrawAmount)
        {
            if (withdrawAmount > Balance)
            {
                Console.WriteLine(AccountType + " " + AccountId + "; Transaction Failed; Withdrawal "
                    + withdrawAmount + "; Fee $" + Fees + "; balance $" + Balance);
                Balance -= Fees;
            }
            else
            {
                Balance -= withdrawAmount;
                Console.WriteLine("amount has been withdrawed.");
            }
        }
        public override void CalculateInterest() {
            Balance = Balance * ((InterestRate / 100) + 1);
        }
    }
    class OmniAccount : Account
    {
        private int accountId;
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        private string accountType;
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private float interestRate;
        public float InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        private float fees;
        public float Fees
        {
            get { return fees; }
            set { fees = value; }
        }
        private float overdraftLimit;
        public float OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        public override string CheckBalance()
        {
            Console.WriteLine("the balance is: $" + Balance);
            string a = AccountType + " " + AccountId + "; Fee $" + Fees + "; balance $" + Balance;
            return a;
        }
        public override void Withdraw(float withdrawAmount)
        {
            if (withdrawAmount > Balance)
            {
                Console.WriteLine(AccountType + " " + AccountId + "; Transaction Failed; Withdrawal "
                    + withdrawAmount + "; Fee $" + Fees + "; balance $" + Balance);
                Balance -= Fees;
            }
            else
            {
                Balance -= withdrawAmount;
                Console.WriteLine("amount has been withdrawed.");
            }
        }
        public override void CalculateInterest() {
            Balance = Balance * ((InterestRate / 100) + 1);
        }

    }

}
