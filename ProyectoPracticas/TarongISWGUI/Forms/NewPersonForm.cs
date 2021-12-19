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
        protected NewContractForm newContractForm;

        public NewPersonForm(NewContractForm newContractForm, ITarongISWService service) : base(service)
        {
            InitializeComponent();
            this.newContractForm = newContractForm;
        }

        private void NewPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Person(object sender, EventArgs e)
        {
            try {
                Person p = new Person(textBox1.Text, textBox2.Text);
                service.AddPerson(p);
            } catch (Exception er) { MessageBox.Show(er.ToString(), "Error"); }
        }

        //No borrar, hace falta, se usa en NewContractForm 
        public virtual void Clear() {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
