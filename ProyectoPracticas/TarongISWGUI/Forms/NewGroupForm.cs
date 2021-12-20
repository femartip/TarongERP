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
        private NewContractFrom newContractForm;
        public NewGroupForm(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            newContractForm = new NewContractFrom(service);
        }

        private void NewGroupForm_Load(object sender, EventArgs e)
        {
            Members_ListBox.Items.Clear();
            ICollection<Contract> contracts = service.GetAllContracts();
            if (contracts != null)
                foreach (Contract c in contracts)
                    if(c.Active()) Members_ListBox.Items.Add(c.Hired.Id);
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
                if (service.GetAllGroups().Where<Group>(x => x.Parcel == parcel) != null)
                {
                    MessageBox.Show(this, "Esta parcela ya tiene un grupo para este dia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Members_groupBox.Visible = true;
                }

            }
            else
            {
                MessageBox.Show(this, "El id de parcela introducido no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else MessageBox.Show(this, "Hay campos vacios o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "Cuadrilla creada correctamente", "Cuadrilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
