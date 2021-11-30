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
        public void AddTrip(Trip t)
        {
            Trips.Add(t);
        }
        public Trip LastTrip()
        {
            return Trips.Last<Trip>();
        }
        public List<Trip> TripsByDate(DateTime initialDate, DateTime finalDate)
        {
            return Trips.Where<Trip>(x => x.ParcelExit >= initialDate && x.CoopArrival <= finalDate).ToList();
        }
    
}
}
