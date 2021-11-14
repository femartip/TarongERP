using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public double CarriedWeight {
            set;
            get;
        }
        public DateTime? CoopArrival {
            set;
            get;
        }
        public int Id {
            set;
            get;
        }
        public DateTime? ParcelExit {
            set;
            get;
        }
        public DateTime? UnloadTime {
            set;
            get;
        }
        public ICollection<Crate> Crates
        {
            set;
            get;
        }
    }
}
