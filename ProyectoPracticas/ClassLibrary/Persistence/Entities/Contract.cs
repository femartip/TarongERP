using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Contract
    {
       
        public string BankAccount
        {
            get;
            set;
        }

        [Key]
        public int Id
        {
            get;
            set;
        }
        public DateTime InitialDate
        {
            get;
            set;
        }
        public string SSN
        {
            get;
            set;
        }

        [InverseProperty("Contracts")]
        public virtual Person Hired
        {
            get;
            set;
        }

        [InverseProperty("Contract")]
        public virtual ICollection<Crate> Crates
        {
            get;
            set;
        }

        [InverseProperty("Members")]
        public virtual ICollection<Group> Groups
        {
            get;
            set;
        }
    }
}
