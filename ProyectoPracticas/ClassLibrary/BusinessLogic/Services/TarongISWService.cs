using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Persistence;
using TarongISW.Entities;

namespace TarongISW.BusinessLogic.Services
{
    public class TarongISWService : ITarongISWService
    {
        private readonly IDAL dal;
        public TarongISWService(IDAL dal)
        {
            this.dal = dal;
        }

        public void removeAllData()
        {
            dal.RemoveAllData();
            dal.Commit();
        }

        public void addPerson(Person person)
        {
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person already exists.");
        }

        public void addContract(Contract contract) 
        { 

        }

        public void addCrate(Crate crate) 
        {
            if (dal.GetWhere<Crate>(x => x.Group.Parcel == crate.Group.Parcel && x.Group.Date == crate.Group.Date) != null) 
            {
                throw new ServiceException("Another crate already");
            }
            if (crate.Group.Members.Distinct().Count() != crate.Group.Members.Count())
            {
                throw new ServiceException("Member repeated");
            }


        }
    }
}
