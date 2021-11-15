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

        public Truck(String id, double maximumAuthorisedMass, double tareWeight) : this()
        {
            this.MaximunWeight = maximumAuthorisedMass - tareWeight;
            this.MaximumAuthorisedMass = maximumAuthorisedMass;
            this.Id = id;
            this.TareWeight = tareWeight;
        }
    }
}
