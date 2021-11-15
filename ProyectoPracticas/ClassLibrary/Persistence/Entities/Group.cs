using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarongISW.Entities
{
    public partial class Group
    {
        public DateTime Date 
        {
            get;
            set;
        }

        [Key]
        public int Id {
            get;
            set;
        }

        [InverseProperty("Group")]
        public virtual ICollection<Crate> Crates {
            get;
            set;
        }

        [InverseProperty("Groups")]
        public virtual ICollection<Contract> Members
        {
            get;
            set;
        }

        [InverseProperty("Groups")]
        public virtual Parcel Parcel{
            get;
            set;
        }
    }
}
