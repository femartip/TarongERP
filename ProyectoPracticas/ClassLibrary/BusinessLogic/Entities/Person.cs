using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Person
    {
        public Person() 
        {
            Parcels = new List<Parcel>();
            Contracts = new List<Contract>();
        }
        public Person(String id, String Name) : this () 
        {
            this.Name = Name;
            this.Id = id;


        }

        public Contract LastActiveContract()
        {
            if (Contracts.Count == 0) return null;
            Contract lastCount = Contracts.OrderBy(cont => cont.InitialDate).Last();
            if (lastCount.Active()) return lastCount;
            else return null;
        }
    }
}
