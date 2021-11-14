using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Truck
    {
        public double MaximunWeight
        {
            get;
            set;
        }
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
        public ICollection<Trip> Trips
        {
            set;
            get;
        }
    }
}
