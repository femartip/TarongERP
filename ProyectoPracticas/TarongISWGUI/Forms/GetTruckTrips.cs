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
    public partial class GetTruckTrips : TarongISWFormBase
    {
        public GetTruckTrips(ITarongISWService service) : base(service)
        {
            InitializeComponent();
        }

        private void plate_textbox_change(object sender, EventArgs e)
        {

        }

        private void Search_click(object sender, EventArgs e)
        {
            if (dateTimePickerInit.Value <= dateTimePickerFinal.Value)
            {
                Lista_listView.Visible = true;
                Lista_listView.Items.Clear();
                
                rellenarLista();
            }
            else
            {
                MessageBox.Show(this, "Invalid dates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void rellenarLista()
        {
            try
            {
                Truck truck = service.FindTruckById(textBox1.Text);
                List<Trip> TripsInDate = truck.TripsByDate(dateTimePickerInit.Value, dateTimePickerFinal.Value);

                foreach (Trip t in TripsInDate)
                {
                    Lista_listView.Items.Add(new ListViewItem(new string[]
                    {
                        t.Crates.First().Group.Parcel.CadastralReference,
                        t.Crates.First().Group.Date.ToString(),
                        t.Crates.Count.ToString(),
                        t.CarriedWeight.ToString()
                    })); ;
                }
                Lista_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                Lista_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
