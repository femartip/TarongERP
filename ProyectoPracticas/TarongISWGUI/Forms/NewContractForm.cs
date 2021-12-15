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

namespace TarongISW.Presentation
{
    public partial class NewContractFrom : TarongISWFormBase
    {
        public NewContractFrom() : base()
        {
            InitializeComponent();
        }

        protected virtual bool fieldsOK()
        {
            return
                !string.IsNullOrEmpty(textBoxDNI.Text) &&
                !string.IsNullOrEmpty(textBoxBankAccount.Text) &&
                !string.IsNullOrEmpty(textBoxSNN.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (fieldsOK())
            {
                if (service.FindPersonById(textBoxDNI.Text) == null)
                {
                    MessageBox.Show("Person with this DNI doesn not exists", "Error");
                    //Call Alta Persona 
                }
                else {
                    Person p = service.FindPersonById(textBoxDNI.Text);
                    Contract c = new Contract(textBoxBankAccount.Text, dateTimePickerInitDate.Value, textBoxSNN.Text, p);
                    if (comboBoxHired.Text == "Permanent")
                    {
                        //Intentas añadir el contrato
                    }
                    else if (comboBoxHired.Text == "Temporary")
                    {
                        //Intentas añadir el contrato
                    }
                    else {
                        MessageBox.Show("Value of Hired not aceptable", "Error");
                    }
                }

            }
            else {
                MessageBox.Show("Missing information","Error");
            }
        }

        
    }
}
