using BankApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    internal interface ICustomerService
    {
        public Customer CreateCustomer(int id, string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender, string accountNumber, decimal accountBalance, bool accountStatus);

        public Customer GetCustomer(string email);
        public void GetAllCustomer();

        public Customer LogInCustomer(string email, string password);

        public void Deposit(string accountNumber, decimal ammount);
        public void Withdraw(string accountNumber, decimal ammount);
        public void Transfer(string SenderaccountNumber, string receiverAccountNumber, decimal ammount);
    }
}
