﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Persistence.Entities
{
    public partial class Contract
    {
       
        public string BankAccount
        {
            get;
            set;
        }
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
        public virtual Person Hired
        {
            get;
            set;
        }
        public virtual ICollection<Crate> Crates
        {
            get;
            set;
        }
        public virtual ICollection<Group> Groups
        {
            get;
            set;
        }
    }
}
