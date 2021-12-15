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
    public partial class TarongISWFormBase : Form
    {
        protected ITarongISWService service;

        public TarongISWFormBase()
        {
            InitializeComponent();
        }
        public TarongISWFormBase(ITarongISWService service) : this()
        {
            this.service = service;
        }
    }
}
