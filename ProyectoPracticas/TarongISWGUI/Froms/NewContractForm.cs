using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarongISWGUI
{
    public partial class TarongISWApp : Form
    {
        public TarongISWApp()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected override bool fieldsOK()
        {
            int result;
            return
                base.fieldsOK() &&
                !string.IsNullOrEmpty(textBoxDNI.Text) &&
                !string.IsNullOrEmpty(textBoxBankAccount.Text) &&
                !string.IsNullOrEmpty(textBoxHired.Text) &&
                !string.IsNullOrEmpty(textBoxSNN.Text);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (fieldsOk()) { }
        }
    }
}
