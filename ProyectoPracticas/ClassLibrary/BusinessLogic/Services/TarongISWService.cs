﻿using System;
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
            return dal.GetAll<Contract>().ToList();
        }
        public void AddPermanent(Permanent perm)    //Caso de Uso 1
        {   
            if (perm.Hired.LastActiveContract() != null)
            {
                throw new ServiceException(perm.Id + " already has an active contract");
            }
            else
            {
                dal.Insert<Permanent>(perm);
                dal.Commit();
            }
        }
        public void AddTemporary(Temporary temp)
        {
            if (temp.Hired.LastActiveContract() != null)
            {
                throw new ServiceException(temp.Id + " already has an active contract");
            }
            else
            {
                dal.Insert<Temporary>(temp);
                dal.Commit();
            }
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
            return dal.GetById<Parcel>(cadas);
        }

        public void AddGroup(Group group)
        {
            if (group.Members.Except(dal.GetWhere<Contract>(x => x.Groups.Any(y => y.Date == group.Date))).Count() == group.Members.Count()) {
                throw new ServiceException("A member already exists on that date.");
            }
            else if (dal.GetWhere<Group>(x => x.Parcel.CadastralReference == group.Parcel.CadastralReference).Any())
            {
                if (!dal.GetWhere<Group>(x => x.Date == group.Date).Any())
                {
                    dal.Insert<Group>(group);
                    dal.Commit();
                }
                else throw new ServiceException("A group is already assigned on date: " + group.Date + " on the parcel: " + group.Parcel.CadastralReference);
            }
            else
            {
                dal.Insert<Group>(group);
                dal.Commit();
            }
        }
        #endregion

        #region Asignar viaje a camión
        public Truck FindTruckById(string id) //Caso de uso 4
        {
            if (dal.GetById<Truck>(id) != null)
            {
                throw new ServiceException("A truck with id: " + id + " does not exist.");
            }
            else { return dal.GetById<Truck>(id); }
        }
        public List<Trip> GetAllTrips()
        {
            return dal.GetAll<Trip>().ToList();
        }
        #endregion

        #region Añadir cajón a viaje
        public void AddCrate(Crate crate) //Caso de uso 5
        {
            if (crate.Group.Members.Contains<Contract>(crate.Contract)) // Ese miembro pertenece a la cuadrilla
            {
                if ((crate.Trip.CarriedWeight + crate.WeightInParcel) < crate.Trip.Truck.MaximunWeight)    // La caja no sobrepasa la MMA
                {
                    dal.Insert<Crate>(crate);
                    dal.Commit();
                }
                else { throw new ServiceException("The crate:" + crate.Id + "surpass truck's MMA."); }
            }
            else { throw new ServiceException("The person:" + crate.Contract.Hired.Name + " is not a part of the group."); }
        }

        public List<Crate> GetAllCrates()
        {
            return dal.GetAll<Crate>().ToList();
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
            return dal.GetAll<Truck>().ToList(); 
        }
           
        public List<Trip> GetTruckTrips(string plateNumber, DateTime startDate, DateTime endDate)
        {
            if (FindTruckById(plateNumber) == null) 
            {
                throw new ServiceException("Truck not exists");
            }
            if (endDate.CompareTo(startDate) > 0) 
            {
                throw new ServiceException("Invalid dates");
            }
            return FindTruckById(plateNumber).TripsByDate(startDate, endDate);
        }
    }
}
