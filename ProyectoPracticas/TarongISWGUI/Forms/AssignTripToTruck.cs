using System;
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
    public partial class AssignTripToTruckForm : TarongISWFormBase
    {
        public AssignTripToTruckForm(ITarongISWService service) : base(service)
        {
            InitializeComponent();
        }
        protected virtual bool fieldsOK =>
                textBoxMatricula.Text.Length == 7 &&
                dateTimePickerSalida.Value != null &&
                dateTimePicker2.Value != null;
        private void AssignTripToTruckForm_Load(object sender, EventArgs e)
        {
            dateTimePickerSalida.MinDate = DateTime.Now;
        }
        private void volverMenu(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void valorMatriculaModificado(object sender, KeyPressEventArgs e)
        {
            if (textBoxMatricula.Text.Length == 7)
            {
                dateTimePickerSalida.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if (fieldsOK) { buttonAñadir.Enabled = true; }
            else { buttonAñadir.Enabled = false; }
        }
        private void fechaSalidaModificada(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePickerSalida.Value;
            if (fieldsOK) { buttonAñadir.Enabled = true; }
            else { buttonAñadir.Enabled = false; }
        }
        private void fechaLlegadaModificada(object sender, EventArgs e)
        {
            if (fieldsOK) { buttonAñadir.Enabled = true; }
            else { buttonAñadir.Enabled = false; }
        }
        private void añadirViajeACamión(object sender, EventArgs e)
        {
            Truck t = service.FindTruckById(textBoxMatricula.Text);
            if (t != null)
            {
                if (dateTimePickerSalida.Value != null && dateTimePicker2.Value != null)
                {
                    Trip tr = new Trip(t);
                    tr.ParcelExit = dateTimePickerSalida.Value;
                    tr.CoopArrival = dateTimePicker2.Value;
                    t.AddTrip(tr);
                    MessageBox.Show("Trip added to truck.", "Success");
                }
                else if (dateTimePickerSalida.Value == null)
                {
                    MessageBox.Show("Enter a valid exit parcel date", "Error");
                }
                else
                {
                    MessageBox.Show("Enter a valid coop arrival date", "Error");
                }
            }
            else { MessageBox.Show("Truck with this Id does not exist", "Error"); }
        }
    }
}
