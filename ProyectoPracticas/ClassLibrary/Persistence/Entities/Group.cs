﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Group
    {
        public DateTime Date 
        {
            get;
            set;
        }
        public int Id {
            get;
            set;
        }
        public virtual ICollection<Crate> Crates {
            get;
            set;
        }
        public virtual ICollection<Contract> Members
        {
            get;
            set;
        }
        public virtual Parcel Parcel{
            get;
            set;
        }
    }
}
