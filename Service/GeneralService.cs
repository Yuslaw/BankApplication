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
    }
}
