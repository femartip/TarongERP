﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Entities;
using TarongISW.Services;

namespace TarongISW.Presentation
{
    public partial class TarongISWApp : TarongISWFormBase
    {
        private NewContractForm newContractForm;

        private NewPersonForm newPersonForm;

        private GetTruckTripsForm getTruckTripsForm;

        private AddCrateToTripForm addCrateToTripForm;

        public TarongISWApp(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            DBInitialization();
            newContractForm = new NewContractForm(service);
            newPersonForm = new NewPersonForm(service);
            getTruckTripsForm = new GetTruckTripsForm(service);
            addCrateToTripForm = new AddCrateToTripForm(service);
        }

        private void exitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToNewContractForm(object sender, EventArgs e)
        {
            newContractForm.ShowDialog();
        }

        private void goNewPersonForm(object sender, EventArgs e)
        {
            newPersonForm.ShowDialog();
        }

        private void goGetTruckTrips(object sender, EventArgs e)
        {
            getTruckTripsForm.ShowDialog();
        }

        private void goAddCrateToTrip(object sender, EventArgs e)
        {
            addCrateToTripForm.ShowDialog();
        }

        void DBInitialization()
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");

            Person p1;
            p1 = new Person("12345678Z", "Juan Abelló");
            service.AddPerson(p1);

            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Orange, 10000, p1);
            service.AddParcel(parcel);

            p1 = new Person("23456789D", "José María Aristrian");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB9999C0001DE", "Valdepuercas, Alia (Cáceres)", Product.Avocado, 18000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);

            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);

            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);

            
            //ADD TRIPS TO TRUCKS
            /*
            t = service.FindTruckById("1234BJP");
            Trip trip = new Trip(t);
            t.AddTrip(trip);
            service.Commit();

            t = service.FindTruckById("1234BJP");
            trip = new Trip(t);
            t.AddTrip(trip);
            service.Commit();

            t = service.FindTruckById("1234AAA");
            trip = new Trip(t);
            t.AddTrip(trip);
            service.Commit();
            */

            //PERSONS AND CONTRACTS

            Person p2;
            Temporary tc;

            p2 = new Person("87654321X", "Juan Sin Nombre");
            service.AddPerson(p2);
            tc = new Temporary("ES8912340100951757864321", DateTime.Today, "SSN0011223344", p2);
            tc.FinalDate = DateTime.Today.AddDays(10);
            service.AddTemporary(tc);



            p2 = new Person("98765432M", "Aitor Tilla");
            service.AddPerson(p2);
            tc = new Temporary("ES9812340100951757864321", DateTime.Today.AddDays(-20), "SSN0112233354", p2);
            service.AddTemporary(tc);




            p2 = new Person("76543210S", "Andrés Trozado");
            service.AddPerson(p2);
            Permanent perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-6), "SSN0033111144", p2, 14000.00);
            service.AddPermanent(perm);


            p2 = new Person("65432109F", "Helen Chufe");
            service.AddPerson(p2);
            perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-2), "SSN4433221100", p2, 18000.00);
            service.AddPermanent(perm);


            Console.WriteLine("DATA CREATED.");

            //ADD CRATES
            /*
            Crate c1, c2, c3;
            Contract contract;
            Group g;

            parcel = service.FindParcelById("7654321AB9999C0001DE");
            g = new Group(DateTime.Today, parcel);
            g.AddMember(service.FindPersonById("65432109F").LastActiveContract());
            service.AddGroup(g);
            trip = service.FindTruckById("1234AAA").LastTrip();
            contract = service.FindPersonById("65432109F").LastActiveContract();
            service.Commit();

            c1 = new Crate(parcel.Product, 20, contract, g, trip);
            service.AddCrate(c1);

            c2 = new Crate(parcel.Product, 30, contract, g, trip);
            service.AddCrate(c2);

            c3 = new Crate(parcel.Product, 25.5, contract, g, trip);
            service.AddCrate(c3);*/
        }
        }
}
