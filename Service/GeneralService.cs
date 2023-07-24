using BankApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Service
{
    public class GeneralService : GeneralInterface
    {
        
        public void GetAllCustomer()
        {
            var allStudents = CustomerService.customerList;
            foreach (var item in allStudents)
            {
                Console.WriteLine($"The name of customer {item.FirstName}, and accountNumber is {item.AccountNumber}, and balance is {item.AccountBalance}");
            }
        }

        public void ApproveAccount(string accountNumber, bool accountStatus)
        {
            Console.WriteLine("Enter Customer accountNumber");
            string accountNumber = Console.ReadLine();
            foreach (var customer in CustomerService.customerList)
            {
                if(customer.AccountNumber == accountNumber)
                {
                    customer.AccountStatus = true;
                    Console.WriteLine("Account Activated SUCCESFULLY");
                }
                Console.WriteLine("Customer doesnt exist");
            }

        }

        public void DisapproveAccount(string accountNumber, bool accountStatus)
        {
            Console.WriteLine("Enter Customer accountNumber");
            string accountNumber = Console.ReadLine();
            foreach (var customer in CustomerService.customerList)
            {
                if (customer.AccountNumber == accountNumber)
                {
                    customer.AccountStatus = true;
                    Console.WriteLine("Account Activated SUCCESFULLY");
                }
                Console.WriteLine("Customer doesnt exist");
            }

        }
    }
}
