using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Parcel
    {
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

        public virtual Person Owner
        {
            get;
            set;
        }

        public virtual ICollection<Group> Groups
        {
            get;
            set;
        }
    }

}
