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
    public partial class NewGroupForm : TarongISWFormBase
    {
        private NewContractForm newContractForm;
        public NewGroupForm(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            newContractForm = new NewContractForm(service);
        }

        private void NewGroupForm_Load(object sender, EventArgs e)
        {
            Members_ListBox.Items.Clear();
            ICollection<Contract> contracts = service.GetAllContracts();
            if (contracts != null)
                foreach (Contract c in contracts)
                    if(c.Active()) Members_ListBox.Items.Add(c.Hired.Name + ", " + c.Hired.Id);
        }

        private void Parcel_textBox_TextChanged(object sender, EventArgs e)
        {
            Members_groupBox.Visible = false;
        }

        private void Parcela_button_Click(object sender, EventArgs e)
        {
            Parcel parcel = service.FindParcelById(Parcel_textBox.Text);
            if (parcel != null)
            {
                if (parcel.ActiveGroup())
                {
                    MessageBox.Show(this, "This parcil already has a group assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Members_groupBox.Visible = true;
                }

            }
            else
            {
                MessageBox.Show(this, "Parcel id does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewMember_button_Click(object sender, EventArgs e)
        {
            newContractForm.ShowDialog();
        }

        private void CrearCuadrilla_button_Click(object sender, EventArgs e)
        {
            if (FieldsOk())
            {
                addGroup();
            }
            else MessageBox.Show(this, "Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool FieldsOk()
        {
            return service.FindParcelById(Parcel_textBox.Text) != null && Members_ListBox.CheckedItems.Count != 0;
        }

        private void addGroup()
        {
            Parcel parcel = service.FindParcelById(Parcel_textBox.Text);
            Group group = new Group(DateTime.Today, parcel);
            try
            {
                foreach (string id in Members_ListBox.CheckedItems.Cast<string>())
                {
                    group.AddMember(service.FindPersonById(id).LastActiveContract());
                }
                service.AddGroup(group);
                MessageBox.Show(this, "Group sucessfully created", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}
