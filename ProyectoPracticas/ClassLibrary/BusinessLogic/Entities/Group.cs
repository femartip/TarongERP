using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Group
    {

        public Group() {
            //Colecciones 
            Crates = new List<Crate>();
            Members = new List<Contract>();
        }

        public Group(DateTime date, Parcel parcel) : this() {
            this.Date = date;
            //relaciones a 1 
            Parcel = parcel;
            //Colecciones 
        }
    }
}
