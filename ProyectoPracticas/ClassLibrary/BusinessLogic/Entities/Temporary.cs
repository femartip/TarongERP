using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Temporary
    {
        public Temporary()
        {

        }
        public Temporary(String bankAccount, DateTime initialDate, String SSN, Person hired) : base(bankAccount, initialDate, SSN, hired)
        {
            
        }
    }
}

