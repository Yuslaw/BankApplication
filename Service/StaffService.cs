using BankApplication.Entity;
using BankApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Service
{
    internal class StaffService : IStaffService
    {
        public static List<Staff> staffList = new List<Staff>();

        public bool ApproveAccount(string accountNumber, bool accountStatus)
        {
            throw new NotImplementedException();
        }

        public Staff CreateStaff(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender, Level level)
        {
            int id = staffList.Count + 1;
            var staffId = GenerateStaffId();
            
            throw new NotImplementedException();
        }

        public bool DeactivateAccount(string accountNumber, bool accountStatus)
        {
            throw new NotImplementedException();
        }

        public void GetAllStaff()
        {
            throw new NotImplementedException();
        }

        public Staff GetStaff(string email)
        {
            throw new NotImplementedException();
        }

        public Staff LogInStaff(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Staff UpdateStaff(string fName, string lName, string email, string phoneNumber, string password, string address, Gender gender)
        {
            throw new NotImplementedException();
        }

        private string GenerateStaffId()
        {
            return $"GTB/{Guid.NewGuid().ToString().Substring(0,5)}/";

            
        }
    }
}
