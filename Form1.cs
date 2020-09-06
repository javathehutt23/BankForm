using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form1 : Form
    {
        Customer person1 = new Customer();
        EverydayAccount everyday1 = new EverydayAccount();
        InvestmentAccount invest1 = new InvestmentAccount();
        OmniAccount omni1 = new OmniAccount();
        string lastTransaction;
        public Form1()
        {
            InitializeComponent();

            person1.CustomerId = 1; person1.Name = "John Smith"; person1.ContactDetails = "0124322";
            everyday1.customerId = person1; everyday1.AccountType = "Everyday"; everyday1.AccountId = 1; everyday1.Balance = 200;
            invest1.customerId = person1; invest1.AccountId = 2; invest1.AccountType = "Investment"; invest1.Balance = 1300; invest1.Fees = 10; invest1.InterestRate = 7;
            omni1.customerId = person1; omni1.AccountId = 3; omni1.AccountType = "Omni"; omni1.Balance = 800; omni1.Fees = 10; omni1.InterestRate = 5; omni1.OverdraftLimit = 1000;

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            string a ="";
            if (lsbAccounts.SelectedItem.ToString() == "Everyday1") { a = everyday1.CheckBalance(); }
            else if (lsbAccounts.SelectedItem.ToString() == "Invest1") { a = invest1.CheckBalance(); }
            else if (lsbAccounts.SelectedItem.ToString() == "Omni1") { a = omni1.CheckBalance(); }
            else { a = "Please select an account before checking the balance"; }           
            lblBalance.Text = a;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            float b=0;
            try { b = float.Parse(txbDeposit.Text); }
            catch (Exception ex) { MessageBox.Show("Enter a valid number"); Console.WriteLine(ex); }
            string a = "";
            if (lsbAccounts.SelectedItem.ToString() == "Everyday1") { a=everyday1.Deposit(everyday1.Balance, b).ToString(); everyday1.Balance = float.Parse(a); EverydayTransaction("Deposit", b); }
            else if (lsbAccounts.SelectedItem.ToString() == "Invest1") { a=invest1.Deposit(invest1.Balance, b).ToString(); invest1.Balance = float.Parse(a); InvestTransaction("Deposit", b); }
            else if (lsbAccounts.SelectedItem.ToString() == "Omni1") { a=omni1.Deposit(omni1.Balance, b).ToString(); omni1.Balance = float.Parse(a); OmniTransaction("Deposit", b); }
            else { a = "Please select an account before checking the balance"; }
            lblDeposit.Text = a;
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            float b = 0;
            try { b = float.Parse(txbDeposit.Text); }
            catch (Exception ex) { MessageBox.Show("Enter a valid number"); Console.WriteLine(ex); }
            string a = "";
            if (lsbAccounts.SelectedItem.ToString() == "Everyday1") { everyday1.Withdraw(b); a = "This account isn't support for withdrawals."; }
            else if (lsbAccounts.SelectedItem.ToString() == "Invest1") { invest1.Withdraw(b); a=invest1.Balance.ToString(); OmniTransaction("Withdrawal", b); }
            else if (lsbAccounts.SelectedItem.ToString() == "Omni1") { omni1.Withdraw(b); a=omni1.Balance.ToString(); OmniTransaction("Withdrawal", b); }
            else { a = "Please select an account before checking the balance"; }
            lblWithdraw.Text = a;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            lsbTransaction.Items[0] = lastTransaction;
        }
        private void EverydayTransaction(string type, float amount)
        {
            lastTransaction = type+" $"+amount+"; "+everyday1.AccountId + " " + everyday1.AccountType + "; Balance $" + everyday1.Balance;
        }
        private void InvestTransaction(string type, float amount)
        {
            lastTransaction = type + " $" + amount + "; " + invest1.AccountId + " " + invest1.AccountType + "; Balance $" + invest1.Balance;
        }
        private void OmniTransaction(string type, float amount)
        {
            lastTransaction = type + " $" + amount + "; " + omni1.AccountId + " " + omni1.AccountType + "; Balance $" + omni1.Balance;
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            string a = "";
            if (lsbAccounts.SelectedItem.ToString() == "Everyday1") { a = "This account isn't support for interest rates."; }
            else if (lsbAccounts.SelectedItem.ToString() == "Invest1") { invest1.CalculateInterest(); a = invest1.Balance.ToString(); InvestTransaction("Interest", invest1.InterestRate); }
            else if (lsbAccounts.SelectedItem.ToString() == "Omni1") { omni1.CalculateInterest(); a = omni1.Balance.ToString(); OmniTransaction("Withdrawal", omni1.InterestRate); }
            else { a = "Please select an account before checking the balance"; }
            lblTransaction.Text = a;
        }
    }
}
