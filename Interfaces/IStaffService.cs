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
        public Staff CreateStaff(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender, Level level);
        public Staff UpdateStaff(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender);

        public Staff GetStaff(string email);
        public void GetAllStaff();

        public Staff LogInStaff(string email, string password);

        public bool ApproveAccount(string accountNumber, bool accountStatus);
        public bool DeactivateAccount(string accountNumber, bool accountStatus);
    }
}
