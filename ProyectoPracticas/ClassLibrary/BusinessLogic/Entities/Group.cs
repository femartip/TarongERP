﻿using System;
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

        public Group(DateTime data, Parcel parcel) : this() {
            this.Date = data;
            //relaciones a 1 
            Parcel = parcel;
            //Colecciones 
            Crates = new List<Crate>();
            Members = new List<Contract>();
        }
        public void AddMember(Contract c)
        {
            if (Members.ToList().Contains(c)) {
                throw new Exception("Miembro ya en la lista");
            }
            this.Members.Add(c);
        }
    }
}
