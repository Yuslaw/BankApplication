using BankApplication.Entity;
using BankApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Service
{
    internal class CustomerService : ICustomerService
    {
        public static List<Customer> customerList = new List<Customer>();
        
        public Customer CreateCustomer(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender)
        {
            int id = customerList.Count + 1;
            Random rand = new Random();
            var accountNumber = rand.Next(10000, 99999).ToString();
            decimal accountBalan = 1000;
            bool status = false;
            Customer customer = new Customer(id, fName, lName, email, address, gender, phoneNumber, password, accountNumber, accountBalan, status);

            customerList.Add(customer);

            return customer;
        }

        public void Deposit(string accountNumber, decimal ammount)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Customer LogInCustomer(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Transfer(string SenderaccountNumber, string receiverAccountNumber, decimal ammount)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(string accountNumber, decimal ammount)
        {
            throw new NotImplementedException();
        }
    }
}
