using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Persistence.Entities
{
    public partial class Truck
    {
        public Truck() {
            //colecciones
            Trips = new List<Trip>();
        }

        public Truck(double maximumWeight, String id, double maximumAuthorisedMass, double tareWeight) : this()
        {
            this.MaximumAuthorisedMass = maximumWeight;
            this.Id = id;
            this.MaximumAuthorisedMass = maximumAuthorisedMass;
            this.TareWeight = tareWeight;
            //colecciones
            Trips = new List<Trip>();
        }
    }
}
