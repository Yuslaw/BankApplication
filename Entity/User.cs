using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Entity
{
    public class User: BaseEntity
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Address;
        public Gender Gender;
        public string PhoneNumber;
        public string Password;

        public User(int id, string firstName, string lastName, string email, string address, Gender gender, string phoneNumber, string password): base(id)
        {
           
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
