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
    }
}
