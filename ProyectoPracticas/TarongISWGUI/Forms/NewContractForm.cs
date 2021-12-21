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
    public partial class NewContractForm : TarongISWFormBase
    {
        private NewPersonForm newPersonForm;
        public NewContractForm(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            //newPersonFormTemp = new NewPersonForm(this, service);
            newPersonForm = new NewPersonForm(service);
        }

        protected virtual bool fieldsOKTemp()
        {
            return
                !string.IsNullOrEmpty(textBoxDNI.Text) &&
                !string.IsNullOrEmpty(textBoxBankAccount.Text) &&
                !string.IsNullOrEmpty(textBoxSSN.Text);
        }

        protected virtual bool fieldsOKPerm()
        {
            return
                !string.IsNullOrEmpty(textBoxDNI2.Text) &&
                !string.IsNullOrEmpty(textBoxBankAccount2.Text) &&
                !string.IsNullOrEmpty(textBoxSSN2.Text) &&
                !string.IsNullOrEmpty(textBoxSalary.Text);
        }

        private void addButtonTemp_Click(object sender, EventArgs e)
        {
            if (fieldsOKTemp())
            {
                if (service.FindPersonById(textBoxDNI.Text) == null)
                {
                    MessageBox.Show("Person with this DNI doesn not exists", "Error");
                    //Call Alta Persona 
                }
                else
                {
                    Person p = service.FindPersonById(textBoxDNI.Text);
                    Temporary temp = new Temporary(textBoxBankAccount.Text, dateTimePickerInitDate.Value, textBoxSSN.Text, p, dateTimePickerFinalDate.Value);
                    try
                    {
                        service.AddTemporary(temp);
                        MessageBox.Show("Persona añadida con exito");
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

        private void addButtonPerm_Click(object sender, EventArgs e)
        {
            if (fieldsOKPerm())
            {
                double result;
                if (service.FindPersonById(textBoxDNI2.Text) == null)
                {
                    MessageBox.Show("Person with this DNI doesn not exists", "Error");
                    //Call Alta Persona 
                }
                if (!double.TryParse(textBoxSalary.Text, out result))
                {
                    MessageBox.Show("Slalary must be a number");
                }
                else
                {
                    Person p = service.FindPersonById(textBoxDNI2.Text);
                    Permanent perm = new Permanent(textBoxBankAccount2.Text, dateTimePickerInitDate2.Value, textBoxSSN2.Text, p, double.Parse(textBoxSalary.Text));
                    try
                    {
                        service.AddPermanent(perm);
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

        private void goAddPerson_Click(object sender, EventArgs e)
        {
            //newPersonForm.Clear();
            newPersonForm.ShowDialog();
        }
    }

}