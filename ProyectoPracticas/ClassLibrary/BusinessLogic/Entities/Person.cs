using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Persistence.Entities
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
    }
}
