using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Entities;

namespace TarongISW.BusinessLogic.Services
{
    public interface ITarongISWService
    {
        void addPerson(Person person);
        void addContract(Contract contract);
        void addCrate(Crate crate);
    }
}
