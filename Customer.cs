using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Customer
    {
        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string contactDetails;
        public string ContactDetails
        {
            get { return contactDetails; }
            set { contactDetails = value; }
        }
        private List<Account> customerAccount;
        public List<Account> CustomerAccount
        {
            get { return customerAccount; }
            set { customerAccount = value; }
        }
    }
}
