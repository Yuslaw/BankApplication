using BankApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    public interface ICustomerService
    {
        public Customer CreateCustomer(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender);
        public Customer UpdateCustomer(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender);

        public Customer GetCustomer(string accountNumber);

        public Customer LogInCustomer(string email, string password);

        public void Deposit(string accountNumber, decimal ammount);
        public void Withdraw(string accountNumber, decimal ammount);
        public void Transfer(string SenderaccountNumber, string receiverAccountNumber, decimal ammount);
    }
}
