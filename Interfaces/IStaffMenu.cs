using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    internal interface IStaffMenu
    {
        public void CreateStaffMenu();
        public void UpdateAccountMenu();
        public void LogInCustomerMenu();
        public void ACctivateAccountMenu();
        public void DeactivateMenu();
        public void TransactionHistoryMenu();
    }
}
