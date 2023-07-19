using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Entity
{
    public class Staff: User
    {
        public string StaffId;
        public Level Level;

        public Staff(int id, string firstName, string lastName, string email, string address, Gender gender, string phoneNumber, string password, string staffId, Level level) : base(id, firstName, lastName, email, address, gender, phoneNumber, password)
        {
            StaffId = staffId;
            Level = level;
        }
    }
}
