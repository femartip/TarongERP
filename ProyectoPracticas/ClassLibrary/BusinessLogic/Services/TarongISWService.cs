using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Persistence;
using TarongISW.Entities;


namespace TarongISW.Services
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
                Commit();
            }
            else throw new ServiceException("Persona con identificador " + person.Id + " ya existe.");
        }

        public void AddParcel(Parcel parcel)
        {
            // Restriction: there cannot be two parcels with the same name.
            if (!dal.GetWhere<Parcel>(x => x.Name == parcel.Name).Any())
            {
                dal.Insert<Parcel>(parcel);
                Commit();
            }
            else throw new ServiceException("Paquete con nombre " + parcel.Name + " ya existe.");
        }

        public void AddTruck(Truck truck)
        {
            // Restriction: there cannot be two trucks with the same id.
            if (dal.GetById<Truck>(truck.Id) == null)
            {
                dal.Insert<Truck>(truck);
                Commit();
            }
            else throw new ServiceException("Camión con Id " + truck.Id + " ya existe.");
        }

        //Nuestros métodos


        public void addGroup(Group group)
        {
            if (dal.GetWhere<Group>(x => x.Parcel == group.Parcel && x.Date == group.Date) != null)
            {
                throw new ServiceException("Another group already");
            }
            if (group.Members.Distinct().Count() != group.Members.Count())
            {
                throw new ServiceException("Member repeated");
            }
            if (group.Members.Except(dal.GetWhere<Contract>(x => x.Groups.Any(y => y.Date == group.Date))).Count() == group.Members.Count())
            {
                throw new ServiceException("Memebr already in other group");
            }
            dal.Insert<Group>(group);
            Commit();

        }

        public List<Group> GetAllGroups()
        {
            return new List<Group>(dal.GetAll<Group>());
        }

        public void AssignTripToTruck(string plateNumber) //Caso de uso 4
        {
            if (dal.GetById<Truck>(plateNumber) != null)
            {
                dal.GetById<Truck>(plateNumber).Trips.Add(dal.GetWhere<Trip>(z => z.Truck == null).First());
                Commit();
            }
            else throw new ServiceException("No existe camión con  matricula " + plateNumber + ".");
        }

        public Person FindPersonById(string id) 
        {
            throw new NotImplementedException();
        }


        public void AddPermanent(Permanent perm)    //Caso de Uso 1
        {
            if (dal.GetById<Person>(perm.Id) == null) {
                //Call Alta Persona, ns que es 
            } else if (dal.Exists<Contract>(perm.Id)) {
                throw new ServiceException("Contract already exists");
            }
            Permanent cnt;
            try
            {
                cnt = new Permanent(perm.BankAccount, perm.InitialDate, perm.SSN, perm.Hired, perm.Salary);
            }
            catch (ServiceException) {
                throw new ServiceException("Infomation not valid");
            }
            dal.Insert<Contract>(cnt);
            dal.Commit();
        }

        public void AddTemporary(Temporary temp)    //Caso de Uso 1
        {
            if (dal.GetById<Person>(temp.Id) == null)
            {
                //Call Alta Persona, ns que es 
            }
            else if (dal.Exists<Contract>(temp.Id))
            {
                throw new ServiceException("Contract already exists");
            }
            Temporary cnt;
            try
            {
                cnt = new Temporary(temp.BankAccount, temp.InitialDate, temp.SSN, temp.Hired);
            }
            catch (ServiceException)
            {
                throw new ServiceException("Infomation not valid");
            }
            dal.Insert<Contract>(cnt);
            dal.Commit();
        }

        public List<Contract> GetAllContracts()
        {
            return new List<Contract>(dal.GetAll<Contract>());
        }

     

        public Parcel FindParcelById(string cadas)
        {
            throw new NotImplementedException();
        }

        public void AddGroup(Group group)
        {
            throw new NotImplementedException();
        }

        public Truck FindTruckById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Truck> GetAllTrucks()
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAllTrips()
        {
            throw new NotImplementedException();
        }

        public void AddCrate(Crate crate)
        {
            throw new NotImplementedException();
        }

        public List<Crate> GetAllCrates()
        {
            throw new NotImplementedException();
        }

        public void AddCrateToTrip(Parcel p, string dni, string plateNumber, Product product, double weightInParcel)
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetTruckTrips(string plateNumber, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
