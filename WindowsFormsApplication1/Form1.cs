using GestDepLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        protected IGestDepService service;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(IGestDepService service) : this()
        {
            this.service = service;
        }
        private void VehicleRentalFormBase_Load(object sender, EventArgs e)
        {

        }

    }
}
