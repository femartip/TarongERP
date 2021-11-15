using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarongISW.Entities
{
    public partial class Person
    {
        [Key]
        public String Id {
            set;
            get;
        }
        public String Name {
            set;
            get;
        }

        [InverseProperty("Owner")]
        public virtual ICollection<Parcel> Parcels
        {
            get;
            set;
        }

        [InverseProperty("Hired")]
        public virtual ICollection<Contract> Contracts 
        {
            set;
            get;
        }
    }
}
