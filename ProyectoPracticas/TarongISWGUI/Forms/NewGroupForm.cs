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
    public partial class NewGroupForm : TarongISWFormBase
    {
        public NewGroupForm() : base()
        {
            InitializeComponent();
        }

        private void carga(object sender, EventArgs e)
        {
            Miembros_listBox.MultiColumn = true;
            Miembros_listBox.Items.AddRange((ListBox.ObjectCollection)service.GetAllContracts().Where(x => x.Active()));
        }
    }
}
