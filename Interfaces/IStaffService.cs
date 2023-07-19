using BankApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    internal interface IStaffService
    {
        public Staff CreateCustomer(int id, string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender, string staffId, Level level);

        public Staff GetStaff(string email);
        public void GetAllStaff();

        public Staff LogInStaff(string email, string password);

        public void GetAllCustomer();

        public bool ApproveAccount(string accountNu);
    }
}
