using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISW.Persistence
{
    public class TarongISWDbContext : DbContextISW
    {

        public TarongISWDbContext() : base("Name=TarongISWDbConnection") { }
        public IDbSet<Contract> Contracts  { get; set; }
        public IDbSet<Crate> Crates { get; set; }
        public IDbSet<Group> Groups { get; set; }
        public IDbSet<Parcel> Parcels { get; set; }
        public IDbSet<Permanent> Permanents  { get; set; }
        public IDbSet<Person> People { get; set; }
        public IDbSet<Temporary> Temporaries  { get; set; }
        public IDbSet<Trip> Trips { get; set; }
        public IDbSet<Truck> Trucks { get; set; }
}
}
