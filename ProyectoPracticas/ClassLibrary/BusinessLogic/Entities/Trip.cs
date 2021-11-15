﻿using System;
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

        public Trip(Truck truck) : this()
        {
            //this.CarriedWeight = carriedWeight;
            this.Truck = truck;
        }
    }
}
