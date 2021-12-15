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

namespace TarongISW.Presentation
{
    public partial class TarongISWApp : TarongISWFormBase
    {
        private NewContractFrom newContractFrom;

        public TarongISWApp(ITarongISWService service) : base(service)
        {
            InitializeComponent();
            newContractFrom = new NewContractFrom(service);
        }

        private void exitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToNewContractForm(object sender, EventArgs e)
        {
            newContractFrom.ShowDialog();
        }
    }
}
