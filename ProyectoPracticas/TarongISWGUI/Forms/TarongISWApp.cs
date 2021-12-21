using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Services;
using TarongISW.Entities;

namespace TarongISW.Presentation
{
    public partial class TarongISWApp : TarongISWFormBase
    {
        private AssignTripToTruckForm newAssignTripToTruckForm;
        private NewContractFrom newContractFrom;
        private NewGroupForm newGroupForm;

        public TarongISWApp(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            this.service = service;
            //DBInitialization();
            newAssignTripToTruckForm = new AssignTripToTruckForm(service);
            newContractFrom = new NewContractFrom(service);
            newGroupForm = new NewGroupForm(service);
        }

        private void exitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToNewContractForm(object sender, EventArgs e)
        {
            newContractFrom.ShowDialog();
        }

        private void goNewGroupForm(object sender, EventArgs e)
        {
            newGroupForm.ShowDialog();
        }

        private void goToAssignTripToTruckForm(object sender, EventArgs e)
        {
            newAssignTripToTruckForm.ShowDialog();
        }

        void DBInitialization()
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");
            
            Person p1;
            Permanent c;
            p1 = new Person("12345678Z", "Juan Abelló");
            service.AddPerson(p1);
            c = new Permanent("cuentaBanco", DateTime.Today, "12345",p1,1200.0);
            service.AddPermanent(c);
            p1 = new Person("23456789D", "José María Aristrian");
            service.AddPerson(p1);
            p1 = new Person("34567890V", "Junta de Andalucía");
            service.AddPerson(p1);
            
            
            

            
            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Orange, 10000, p1);
            service.AddParcel(parcel);

            p1 = new Person("23456789D", "José María Aristrian");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB9999C0001DE", "Valdepuercas, Alia (Cáceres)", Product.Avocado, 18000, p1);
            service.AddParcel(parcel);

            p1 = new Person("34567890V", "Junta de Andalucía");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB1111C0001DE", "La Almoraima (Cadiz)", Product.Kiwi, 16000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);

            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);

            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);

            //ADD TRIPS TO TRUCKS

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


        }
    }
}
