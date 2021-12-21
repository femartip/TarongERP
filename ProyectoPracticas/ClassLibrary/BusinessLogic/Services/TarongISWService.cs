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

        #region Alta contrato de trabajador 
        public List<Contract> GetAllContracts()
        {
            return new List<Contract>(dal.GetAll<Contract>());
        }
        public void AddPermanent(Permanent perm)    //Caso de Uso 1
        {
            if (dal.GetById<Permanent>(perm.Id) == null)
            {
                dal.Insert<Permanent>(perm);
                dal.Commit();
            }
            else throw new ServiceException("Contract " + perm.Id + " already exists.");
        }
        public void AddTemporary(Temporary temp)
        {
            if (dal.GetById<Temporary>(temp.Id) == null)
            {
                dal.Insert<Temporary>(temp);
                dal.Commit();
            }
            else throw new ServiceException("Contract " + temp.Id + " already exists.");
        }
        #endregion

        #region Alta Persona
        public Person FindPersonById(string id) //Caso de uso 2
        {
            return dal.GetById<Person>(id);
        }

        public void AddPerson(Person person)
        {
            // Restricction: there cannot be two people with the same id.
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                Commit();
            }
            else throw new ServiceException("Person with Id: " + person.Id + " already exists.");
        }
        #endregion

        #region Alta cuadrilla
        public Parcel FindParcelById(string cadas) //Caso uso 3
        {
            try
            {
                return dal.GetById<Parcel>(cadas);
            }
            catch (ServiceException e)
            {
                throw new ServiceException("Parcel con id: " + cadas + "no existe en la BD");
            }
        }

        public void AddGroup(Group group)
        {
            if (dal.GetById<Group>(group.Id) == null)
            {
                foreach (Group gru in GetAllGroups())
                {
                    if (gru.Date == group.Date && gru.Parcel == group.Parcel)
                    {
                        throw new ServiceException("2 groups cant work the same day at the same parcel");
                    }

                    ICollection<Contract> aux = gru.Members;
                }
                dal.Insert<Group>(group);
                dal.Commit();
            }
            else throw new ServiceException("Group con Id " + group.Id + " already exists.");
        }
        #endregion

        #region Asignar viaje a camión
        public Truck FindTruckById(string id) //Caso de uso 4
        {
            try
            {
                return dal.GetById<Truck>(id);
            }
            catch (ServiceException e)
            {
                throw new ServiceException("Tuck: " + id + "does not exists");
            }
        }
        public List<Trip> GetAllTrips()
        {
            return new List<Trip>(dal.GetAll<Trip>());
        }
        #endregion

        #region Añadir cajón a viaje
        public void AddCrate(Crate crate)
        {
            if (dal.GetById<Crate>(crate.Id) == null)
            {
                Person p = crate.Contract.Hired;
                if (p.LastActiveContract().Groups.Contains(crate.Group))
                {


                    if (!(crate.Trip.CarriedWeight + crate.WeightInParcel > crate.Trip.Truck.MaximunWeight))
                    {
                        crate.Trip.CarriedWeight += crate.WeightInParcel;
                        dal.Insert<Crate>(crate);
                        dal.Commit();

                    }
                    else throw new ServiceException("This crate exceeds total weight");

                }
                else throw new ServiceException("This crate and Person with Id " + crate.Contract.Hired.Id + " its not in the group.");
            }
            else throw new ServiceException("Crate whit Id " + crate.Id + " already exists.");
        }

        public List<Crate> GetAllCrates()
        {
            return new List<Crate>(dal.GetAll<Crate>());
        }
        #endregion

        public void AddParcel(Parcel parcel)
        {
            // Restriction: there cannot be two parcels with the same name.
            if (!dal.GetWhere<Parcel>(x => x.Name == parcel.Name).Any())
            {
                dal.Insert<Parcel>(parcel);
                Commit();
            }
            else throw new ServiceException("Parcel with name: " + parcel.Name + " already exists.");
        }

        public void AddTruck(Truck truck)
        {
            // Restriction: there cannot be two trucks with the same id.
            if (dal.GetById<Truck>(truck.Id) == null)
            {
                dal.Insert<Truck>(truck);
                Commit();
            }
            else throw new ServiceException("Truck with Id: " + truck.Id + " already exists.");
        }

        public List<Group> GetAllGroups()
        {
            return new List<Group>(dal.GetAll<Group>());
        }
        
        public List<Truck> GetAllTrucks()
        {
            return new List<Truck>(dal.GetAll<Truck>());
        }
           
        public List<Trip> GetTruckTrips(string plateNumber, DateTime startDate, DateTime endDate)
        {
            if (FindTruckById(plateNumber) == null) 
            {
                throw new ServiceException("Truck not exists");
            }
            if (startDate > endDate) 
            {
                throw new ServiceException("Invalid dates");
            }
            return FindTruckById(plateNumber).TripsByDate(startDate, endDate);
        }
    }
}
