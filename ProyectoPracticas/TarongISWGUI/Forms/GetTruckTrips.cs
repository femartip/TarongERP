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
    public partial class GetTruckTrips : TarongISWFormBase
    {
        public GetTruckTrips() : base()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) {

            if (service.FindTruckById(textBox1.Text) == null)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                button2.Enabled = false;
            }
            else {
                dateTimePicker1.Enabled = true;
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now < dateTimePicker1.Value)
            {
                MessageBox.Show("Error fecha inválida");
                dateTimePicker2.Enabled = false;
                button2.Enabled = false;
                dateTimePicker1.Value = DateTime.Now;
            }
            else {
                dateTimePicker2.Enabled = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Error fecha inválida");
                button2.Enabled = false;
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateList();
        }
            
        private void Reinicio() {
            textBox1.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            button2.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker1.Enabled = false;
        }
        public void GenerateList()
        {
            try
            {
                List<Trip> ListTrip = service.GetTruckTrips(textBox1.Text,dateTimePicker1.Value, dateTimePicker2.Value);
                MessageBox.Show(this, "El camion con la matricula " + textBox1.Text + " ha realizado " + ListTrip.Count + " viajes. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reinicio();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error");
            }
        }
    }
}
