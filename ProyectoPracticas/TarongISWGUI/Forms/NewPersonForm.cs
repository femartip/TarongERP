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
    public partial class NewPersonForm : TarongISWFormBase
    {
        public NewPersonForm() : base()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Person(object sender, EventArgs e)
        {   
            try {
                Person p = new Person(textBox1.Text, textBox2.Text);
                service.AddPerson(p);
                MessageBox.Show("User sucessfully created");
                this.Close();
            } catch (Exception er) { MessageBox.Show(er.Message); }
        }
    }
}
