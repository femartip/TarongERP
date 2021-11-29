using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Contract
    {
        public Contract()
        {
            // Colecciones
            Crates = new List<Crate>();
            Groups = new List<Group>();
        }
        public Contract(string bankAccount, DateTime initialDate, string SSN, Person hired) : this()
        {
            // No se le da valor a Id porque se lo dará EF
            this.BankAccount = bankAccount;
            this.InitialDate = initialDate;
            this.SSN = SSN;
            // Relaciones a 1
            Hired = hired;
            // Colecciones
            Crates = new List<Crate>();
            Groups = new List<Group>();
        }

        internal bool Active()
        {
            if (this is Permanent) return true;
            else {
                Temporary t = (Temporary)this;
                if (t.FinalDate != null)
                    if (t.FinalDate >= DateTime.Today) return true;
                    else return false;
                else return true;
            }
        }
    }
}
