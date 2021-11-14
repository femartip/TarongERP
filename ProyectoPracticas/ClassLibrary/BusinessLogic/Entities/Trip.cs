using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public Trip(){
            //coleccion
            Crates = new List<Crate>();
        }

        public Trip(double carriedWeight, DateTime? coopArrival, int id, DateTime? parcelExit, DateTime? unloadTime) : this()
        {
            this.CarriedWeight = carriedWeight;
            this.CoopArrival = coopArrival;
            this.Id = id;
            this.ParcelExit = parcelExit;
            this.UnloadTime = unloadTime;
            //coleccion

        }
    }
}
