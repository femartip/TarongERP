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
            newPersonForm = new NewPersonForm(this, service);
            textBoxBankAccount.Enabled = false;
            textBoxSSN.Enabled = false;
            textBoxSalary.Enabled = false;
            dateTimePickerFinalDate.Enabled = false;
            dateTimePickerInitDate.Enabled = false;
            addButtonTemp.Enabled = false;
            temp.Enabled = false;
            perm.Enabled = false;
        }

        protected void DNIOk() {
            textBoxBankAccount.Enabled = true;
            textBoxSSN.Enabled = true;
            dateTimePickerInitDate.Enabled = true;
            temp.Enabled = true;
            perm.Enabled = true;
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
                !string.IsNullOrEmpty(textBoxDNI.Text) &&
                !string.IsNullOrEmpty(textBoxBankAccount.Text) &&
                !string.IsNullOrEmpty(textBoxSSN.Text) &&
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
                        Temporary temp = new Temporary(textBoxBankAccount.Text, dateTimePickerInitDate.Value, textBoxSSN.Text, p);
                        temp.FinalDate = dateTimePickerFinalDate.Value;
                        try
                        {
                            service.AddTemporary(temp);
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
            newPersonForm.Clear();
            newPersonForm.ShowDialog();
        }

        private void DNIValido(object sender, EventArgs e)
        {
            if (service.FindPersonById(textBoxDNI.Text) != null) {
                DNIOk();
            }
        }

        private void isTemporary(object sender, EventArgs e)
        {
            if (temp.Checked.Equals(true))
            {
                addButtonTemp.Enabled = true;
                
            }
            else {
                dateTimePickerFinalDate.Enabled = false;
            }
        }

        private void isPermanent(object sender, EventArgs e)
        {
            if (perm.Checked.Equals(true))
            {
                addButtonTemp.Enabled = true;
                textBoxSalary.Enabled = true;
            }
            else
            {
                dateTimePickerFinalDate.Enabled = false;
            }
        }
    }
    
}
