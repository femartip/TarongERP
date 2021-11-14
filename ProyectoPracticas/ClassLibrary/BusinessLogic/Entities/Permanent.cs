using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Permanent
    {
        public Permanent() 
        { 

        }

        public Permanent(double salary, string bankAccount, DateTime initialDate, string SSN,
        Person hired) : base(bankAccount, initialDate, SSN, hired)
        {
            this.Salary = salary;
        }
    }
}
