using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarongISW.Entities
{
    public partial class Parcel
    {
        [Key]
        public String CadastralReference
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public Product Product
        {
            get;
            set;
        }

        public double Size
        {
            get;
            set;
        }

        [InverseProperty("Parcels")]
        public virtual Person Owner
        {
            get;
            set;
        }

        [InverseProperty("Parcel")]
        public virtual ICollection<Group> Groups
        {
            get;
            set;
        }
        public Group LastGroup() 
        {
            return Groups.Last<Group>();
        }
    }

}
