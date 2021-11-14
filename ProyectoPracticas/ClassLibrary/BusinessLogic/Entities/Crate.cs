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
        public Crate(double? loss, Product product, double? weightInCoop, double weightInParcel, Trip trip, Group group, Contract contract) : this(){
            this.Loss = loss;
            this.WeightInCoop = weightInCoop;
            this.WeightInParcel = weightInParcel;
            this.Product = product;
            // Relaciones a 1
            Trip = trip;
            Group = group;
            Contract = contract;
        }
    }
}
