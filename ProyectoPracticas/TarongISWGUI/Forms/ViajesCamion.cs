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
    public partial class ViajesCamionForm : TarongISWFormBase
    {
        public ViajesCamionForm()
        {
            InitializeComponent();
        }

        private void ClickGo(object sender, EventArgs e)
        {
            try
            {
                List<Trip> ListTrip = service.GetTruckTrips(textBoxMatricula.Text, dateTimePickerSalida.Value, dateTimePickerLlegada.Value);
                MessageBox.Show(this, "El camion con la matricula " + textBoxMatricula.Text + " ha realizado " + ListTrip.Count + " viajes. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
        }

        private void textMatriculaChanged(object sender, EventArgs e)
        {
            if (service.FindTruckById(textBoxMatricula.Text) == null)
            {
                dateTimePickerSalida.Enabled = false;
                dateTimePickerLlegada.Enabled = false;
                buttonSearch.Enabled = false;
            }
            else
            {
                dateTimePickerSalida.Enabled = true;
            }
        }

        private void salidaChanged(object sender, EventArgs e)
        {
            if (DateTime.Now < dateTimePickerSalida.Value)
            {
                MessageBox.Show("Error fecha inválida");
                dateTimePickerLlegada.Enabled = false;
                buttonSearch.Enabled = false;
                dateTimePickerSalida.Value = DateTime.Now;
            }
            else
            {
                dateTimePickerLlegada.Enabled = true;
            }
        }

        private void LlegadaChanged(object sender, EventArgs e)
        {
            if (dateTimePickerLlegada.Value < dateTimePickerSalida.Value)
            {
                MessageBox.Show("Error fecha inválida");
                buttonSearch.Enabled = false;
                dateTimePickerLlegada.Value = DateTime.Now;
            }
            else
            {
                buttonSearch.Enabled = true;
            }
        }
    }
}
