﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Temporary : Contract
    {
        public DateTime? FinalDate
        {
            get;
            set;
        }
    }
}
