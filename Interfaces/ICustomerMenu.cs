using BankApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    public interface ICustomerMenu
    {
        public void CreateAaccountMenu();
        public void UpdateAaccountMenu();
        public void LogInCustomerMenu();
        public void DepositMenu();
        public void TransferMenu();
        public void WithdrawalMenu();

        public void CheckAccountBalanceMenu();
        public void TransactionHistoryMenu();
       

    }
}
