using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Person
    {
        public String Id {
            set;
            get;
        }
        public String Name {
            set;
            get;
        }
        public ICollection<Parcel> Parcels
        {
            get;
            set;
        }
        public ICollection<Contract> Contracts 
        {
            set;
            get;
        }
    }
}
