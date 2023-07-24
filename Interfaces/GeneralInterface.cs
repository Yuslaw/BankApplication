using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    public interface GeneralInterface
    {
        public void GetAllCustomer();
        public void ApproveAccount(string accountNumber, bool accountStatus);
        public void DeactivateAccount(string accountNumber, bool accountStatus);
    }
}
