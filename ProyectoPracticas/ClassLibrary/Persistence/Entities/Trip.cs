using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key]
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

        [InverseProperty("Trip")]
        public ICollection<Crate> Crates
        {
            set;
            get;
        }

        [InverseProperty("Trips")]
        public Truck Truck
        {
            set;
            get;
        }
    }
}
