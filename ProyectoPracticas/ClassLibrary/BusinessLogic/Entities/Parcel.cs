﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Parcel
    {
        public Parcel() {
            // Coleciones
            Groups = new List<Group>();
        }

        public Parcel(String cadastralReference, String name, Product product, double size, Person owner) : this() {
            this.CadastralReference = cadastralReference;
            this.Name = name;
            this.Product = product;
            this.Size = size;
            // Relaciones a 1
            Owner = owner;
            // Colecciones
            Groups = new List<Group>();
        }
        public Group LastGroup()
        {
            if (Groups.Count > 0) return Groups.Last<Group>();
            else return null;
        }

        public Boolean ActiveGroup()
        {
            if (LastGroup() == null) return false;
            else return this.LastGroup().Date == DateTime.Today;
        }
    }
}
