using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Persistence;
using TarongISW.Entities;
using System.Linq;

namespace TarongISW.BusinessLogic.Services
{
    public class TarongISWService : ITarongISWService
    {
        private readonly IDAL dal;

        public TarongISWService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void AddPerson(Person person)
        {
            // Restricction: there cannot be two people with the same id.
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Persona con identificador " + person.Id + " ya existe.");
        }

        public void AddParcel(Parcel parcel)
        {
            // Restriction: there cannot be two parcels with the same name.
            if (!dal.GetWhere<Parcel>(x => x.Name == parcel.Name).Any())
            {
                dal.Insert<Parcel>(parcel);
                dal.Commit();
            }
            else throw new ServiceException("Paquete con nombre " + parcel.Name + " ya existe.");
        }

        public void AddTruck(Truck truck)
        {
            // Restriction: there cannot be two trucks with the same id.
            if (dal.GetById<Truck>(truck.Id) == null)
            {
                dal.Insert<Truck>(truck);
                dal.Commit();
            }
            else throw new ServiceException("Camión con Id " + truck.Id + " ya existe.");
        }

        //Nuestros métodos

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
            if (crate.Group.Members.Except(dal.GetWhere<Contract>(x => x.Groups.Any(y => y.Date == crate.Group.Date))).Count() == crate.Group.Members.Count())
            { 
            
            }

        }

        public void AssignTripToTruck(string plateNumber) //Caso de uso 4
        {
            if (dal.GetWhere<Truck>(x => x.Id == plateNumber) != null)
            {
                
                Commit();
            }
            else throw new ServiceException("No existe camión con  matricula " + plateNumber + ".");
        }
}
