using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Entity
{
    public class Customer : User
    {
        public string AccountNumber;
        public decimal AccountBalance;
        public bool AccountStatus;

        public Customer(int id, string firstName, string lastName, string email, string address, Gender gender, string phoneNumber, string password, string accountNumber, decimal accountBalance, bool accountStatus) : base(id, firstName, lastName, email, address, gender, phoneNumber, password)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            AccountStatus = accountStatus;
        }
    }
}
