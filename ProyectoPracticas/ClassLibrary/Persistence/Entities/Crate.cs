using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarongISW.Entities
{
    public partial class Crate
    {
        public double? Loss 
        {
            get;
            set;
        }

        [Key]
        public int Id 
        {
            get;
            set;
        }
        public Product Product
        {
            get;
            set;
        }
        public double? WeightInCoop
        {
            get;
            set;
        }
        public double WeightInParcel
        {
            get;
            set;
        }

        [InverseProperty("Crates")]
        public virtual Trip Trip 
        {
            get;
            set;
        }

        [InverseProperty("Crates")]
        public virtual Group Group 
        {
            get;
            set;
        }

        [InverseProperty("Crates")]
        public virtual Contract Contract 
        {
            get;
            set;
        }
    }
}
