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

        void DBInitialization()
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");

            Person p1;
            Permanent c;
            p1 = new Person("12345678Z", "Juan Abelló");
            service.AddPerson(p1);
            c = new Permanent("cuentaBanco", DateTime.Today, "12345", p1, 1200.0);
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
        }

        private void goToAssignTripToTruckForm(object sender, EventArgs e)
        {
            newAssignTripToTruckForm.ShowDialog();
        }
    }
}
