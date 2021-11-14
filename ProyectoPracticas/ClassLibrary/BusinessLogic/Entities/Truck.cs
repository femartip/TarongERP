using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Truck
    {
        public Truck() {
            //colecciones
            Trips = new List<Trip>();
        }

        public Truck(String id, double maximumWeight, double maximumAuthorisedMass, double tareWeight) : this()
        {
            this.MaximumAuthorisedMass = maximumWeight;
            this.MaximumAuthorisedMass = maximumAuthorisedMass;
            this.Id = id;
            this.TareWeight = tareWeight;
        }
    }
}
