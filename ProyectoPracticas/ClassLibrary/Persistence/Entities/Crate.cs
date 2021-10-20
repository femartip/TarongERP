using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Persistence.Entities
{
    public partial class Crate
    {
        public double? Loss {
            get;
            set;
        }

        public int Id {
            get;
            set;
        }
        public Product Product {
            get;
            set;
        }
        public double? WheightInCoop {
            get;
            set;
        }
        public double WheightInParcel {
            get;
            set;
        }

        public virtual Trip Trip {
            get;
            set;
        }
        public virtual Group Group {
            get;
            set;
        }
        public virtual Contract Contract {
            get;
            set;
        }
    }
}
