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
    public partial class AddCrateToTripForm : TarongISWFormBase
    {
       

        public AddCrateToTripForm(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            textBoxDNI.Enabled = false;
            textBoxPN.Enabled = false;
            textBoxWeight.Enabled = false;
            buttonDNI.Enabled = false;
            buttonPN.Enabled = false;
            buttonAddCrateToTrip.Enabled = false;
            comboBoxProduct.Enabled = false;
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadData();
        }

        public void LoadData()
        {
            comboBoxProduct.DisplayMember = "CadastralReference";
            comboBoxProduct.ValueMember = "CadastralReference";
            comboBoxProduct.DataSource = Enum.GetNames(typeof(Product));
            comboBoxProduct.SelectedIndex = -1;
        }

        protected virtual bool fieldsOk()
        {
            return
                !string.IsNullOrEmpty(textBoxDNI.Text) &&
                !string.IsNullOrEmpty(textBoxParcel.Text) &&
                !string.IsNullOrEmpty(textBoxPN.Text) &&
                !string.IsNullOrEmpty(textBoxWeight.Text) &&
                !string.IsNullOrEmpty(comboBoxProduct.Text);
        }

        private void addCrateToTrip_Click(object sender, EventArgs e)
        {
            if (fieldsOk())
            {
                double result;

                if (double.TryParse(textBoxWeight.Text, out result) == false)
                {
                    MessageBox.Show("Wheight should be a number", "Error");
                }
                else
                {
                    Contract cont = service.FindPersonById(textBoxDNI.Text).LastActiveContract();
                    Group group = service.FindParcelById(textBoxParcel.Text).LastGroup();
                    Trip trip = service.FindTruckById(textBoxPN.Text).LastTrip();
                    Crate caja = new Crate(Product.Avocado, double.Parse(textBoxWeight.Text), cont, group, trip);
                    try
                    {
                        service.AddCrate(caja);
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString(), "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Missing information", "Error");
            }
        }

        private void validParcel(object sender, EventArgs e)
        {
            if (service.FindParcelById(textBoxParcel.Text) == null)
            {
                MessageBox.Show("Parcel does not exsists", "Error");
            }
            else {
                textBoxDNI.Enabled = true;
                buttonDNI.Enabled = true;
            }
        }
       

        private void validDNI(object sender, EventArgs e)
        {

            try
            {
                Person p = service.FindPersonById(textBoxDNI.Text);
                if (p.LastActiveContract() != null && p.LastActiveContract().Groups.Contains(service.FindParcelById(textBoxParcel.Text).LastGroup()))
                {
                    textBoxPN.Enabled = true;
                    buttonPN.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Person not asigned to any parcel", "Error");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Person does not exists", "Error");
            }
           
        }

        private void validPN(object sender, EventArgs e)
        {
            if (service.FindTruckById(textBoxPN.Text) == null)
            {
                MessageBox.Show("Person does not exists", "Error");
            }
            else
            {
                comboBoxProduct.Enabled = true;
                textBoxWeight.Enabled = true;
                buttonAddCrateToTrip.Enabled = true;
            }
        }
    }

        
    
}
