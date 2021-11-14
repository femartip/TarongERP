using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Crate
    {
        public Crate() { 
        
        }
        public Crate(Product product, double? loss, double? weightInCoop, double weightInParcel, Contract contract, Group group, Trip trip) : this(){
            this.Loss = loss;
            this.Product = product;
            this.WeightInCoop = weightInCoop;
            this.WeightInParcel = weightInParcel;
            // Relaciones a 1
            Contract = contract;
            Group = group;
            Trip = trip;
        }
    }
}
