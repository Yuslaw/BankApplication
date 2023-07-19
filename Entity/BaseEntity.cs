using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Entity
{
    public abstract class BaseEntity
    {
        public int Id;

        protected BaseEntity(int id)
        {
            Id = id;
        }
    }
}
