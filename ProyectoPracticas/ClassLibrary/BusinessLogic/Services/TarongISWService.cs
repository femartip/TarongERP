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
        public Person FindPersonById(string id) 
        {
            return dal.GetById<Person>(id);
        }
        public void AddPermanent(Permanent perm)    //Caso de Uso 1
        {
            try
            {
                if(perm.Hired.LastActiveContract() != null)
                {
                    throw new ServiceException("Active contract");
                } else
                {
                    dal.Insert<Permanent>(perm);
                    dal.Commit();
                }
            } catch (ServiceException) { throw new ServiceException("Infomation not valid"); }
        }
        public void AddTemporary(Temporary temp)    //Caso de Uso 1
        {
            try
            {
                if (temp.Hired.LastActiveContract() != null)
                {
                    throw new ServiceException("Active contract");
                }
                else
                {
                    dal.Insert<Temporary>(temp);
                    dal.Commit();
                }
            } catch (ServiceException)
            {
                throw new ServiceException("Infomation not valid");
            }
        }
        public List<Contract> GetAllContracts() 
        {
            return dal.GetAll<Contract>().ToList();
        }
        public Parcel FindParcelById(string cadas) 
        {
            return dal.GetById<Parcel>(cadas);
        }

        public void AddGroup(Group group)
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
        public Truck FindTruckById(string id)
        {
            return dal.GetById<Truck>(id);
        }
        public List<Truck> GetAllTrucks()
        {
            return dal.GetAll<Truck>().ToList(); 
        }
        public List<Trip> GetAllTrips()
        {
            return dal.GetAll<Trip>().ToList();
        }
        public void AddCrate(Crate crate /*,Trip trip*/ )
        {
            /* if ((dal.GetById<Crate>(crate.Id) == null))
             {
                 dal.Insert<Crate>(crate);
                 Commit();
             }
             else throw new ServiceException("La caja con " + crate.Id + " no existe.");
             */
            throw new NotImplementedException();
        }

        public List<Crate> GetAllCrates()
        {
            return dal.GetAll<Crate>().ToList();
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

        public void AddCrateToTrip(Parcel p, string dni, string plateNumber, Product product, double weightInParcel) // Caso de uso 5
        {
            //Crate caja = GetAllCrates().Where(x => x.GetProduct() == product && x.getWeightInParcel = weightInParcel);
            if (dal.GetById<Parcel>(p.CadastralReference) == null)
            {
                throw new ServiceException("Parcel does not exists");
            }
            else if (dal.GetById<Person>(dni) == null)
            {
                throw new ServiceException("Person does not exists");
            }
            else if (dal.GetById<Person>(dni).LastActiveContract() == null)
            {  //Falta -> ||no esta asignada a una cuadrilla en la parcela
                throw new ServiceException("Person not asigned to group or contract not active");
            }
            else if (dal.GetById<Truck>(plateNumber) == null)
            {
                throw new ServiceException("Plate number does not exist");
            } 
            //falta comparar pesos
            else {
                //AddCrate(caja, dal.GetById<Truck>(plateNumber).LastTrip());
                //dal.GetById<Truck>(plateNumber).LastTrip().AddCrate(caja);     //Añade la caja al ultimo viaje del camion
            }
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
        /*
        public List<Trip> GetTruckTrips(string plateNumber, DateTime startDate, DateTime endDate)
        {

                List<Trip> viajes = new List<Trip>();
                Truck t = findTruckById(id);
                if (t != null)
                {

                    viajes = Trip.get(t);
                    int startDate = startDate.Date;
                    int endDate = endDate.Date;

                    viajes;
                }
                else { throw new ServiceException("El camión no existe");  }

                return viajes;
            }
            //throw new NotImplementedException();*/
        }
    }
