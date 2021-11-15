using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarongISW.Entities
{
    public partial class Truck
    {
        public double MaximunWeight
        {
            get;
            set;
        }

        [Key]
        public String Id
        {
            get;
            set;
        }
        public double MaximumAuthorisedMass
        {
            get;
            set;
        }
        public double TareWeight
        {
            get;
            set;
        }

        [InverseProperty("Truck")]
        public ICollection<Trip> Trips
        {
            set;
            get;
        }
    }
}
