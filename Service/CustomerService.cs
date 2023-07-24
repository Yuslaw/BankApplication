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
        public static List<Transaction> TranList = new List<Transaction>();
        
        public Customer CreateCustomer(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender)
        {
            int id = customerList.Count + 1;
            Random rand = new Random();
            var accountNumber = rand.Next(10000, 59988).ToString();
            var accountNumber2 = rand.Next(60000, 90000).ToString();

            string acc = accountNumber + accountNumber2;
            decimal accountBalan = 1000;
            bool status = false;
            Customer customer = new Customer(id, fName, lName, email, address, gender, phoneNumber, password, acc, accountBalan, status);

            customerList.Add(customer);

            return customer;
        }

        public void Deposit(string accountNumber, decimal ammount)
        {
            foreach(var item in customerList)
            {
                if(item.AccountNumber == accountNumber) {
                    item.AccountBalance = item.AccountBalance + ammount;
                    Console.WriteLine("Deposit succesful");
                    Transaction trans = new Transaction(TranList.Count + 1, accountNumber, ammount, DateTime.Now);
                    TranList.Add(trans);
                }
                Console.WriteLine("Not succesful");
            }
        }

        public Customer GetCustomer(string accountNumber)
        {
            foreach(var item in customerList)
            {
                if( item.AccountNumber == accountNumber)
                {
                    return item;
                }
            }

            return null;
        }

        public Customer LogInCustomer(string email, string password)
        {
            foreach (var customer in customerList)
            {
                if (customer.Email == email && customer.Password == password)
                {
                    return customer;
                }

            }
            return null;
        }

        public void Transfer(string senderaccountNumber, string receiverAccountNumber, decimal ammount)
        {
            string name= null;

            foreach(var item in customerList)
            {
                if(senderaccountNumber== item.AccountNumber)
                {
                    if(item.AccountBalance>= ammount)
                    {
                        item.AccountBalance = item.AccountBalance - ammount;
                        Console.WriteLine($"Account debited with {ammount}");
                        name = item.LastName;
                        Transaction trans = new Transaction(TranList.Count + 1, senderaccountNumber, ammount, DateTime.Now);
                        TranList.Add(trans);
                    }
                    Console.WriteLine("Insufficient");


                }
            }

            foreach(var item in customerList)
            {
                if(item.AccountNumber== receiverAccountNumber)
                {
                    
                    Console.WriteLine($"Account name is {item.LastName}, {item.FirstName}");

                    item.AccountBalance = item.AccountBalance +ammount;
                    Console.WriteLine($"Account credited with {ammount} and sender is {name}");
                }
            }


            
            
           
        }

        public Customer UpdateCustomer(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(string accountNumber, decimal ammount)
        {
            foreach (var item in customerList)
            {
                if (item.AccountNumber == accountNumber)
                {
                    if(item.AccountBalance >= ammount)
                    {
                        item.AccountBalance = item.AccountBalance - ammount;
                        Console.WriteLine("Withdrawal succesful");
                        Transaction trans = new Transaction(TranList.Count + 1, accountNumber, ammount, DateTime.Now);
                        TranList.Add(trans);
                    }
                    Console.WriteLine("Insufficient balance");

                }
                
            }
        }
    }
}
