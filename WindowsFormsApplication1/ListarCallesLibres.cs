using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestDepLib.Services;
using GestDepLib.Entities;

namespace WindowsFormsApplication1
{
    public partial class ListarCallesLibres : Form1
    {
        protected GestDepService gestDepService;

        public ListarCallesLibres(IGestDepService service) : base(service)
        {
            InitializeComponent();
            LoadData();

        }

        public void LoadData()
        {
            
            IList<Pool> piscinas = service.AllPools();
            piscinascomboBox1.Items.Clear();
            if (piscinas != null)
                foreach (Pool p in piscinas)
                    piscinascomboBox1.Items.Add(p.Id);
            piscinascomboBox1.SelectedIndex = -1;
            piscinascomboBox1.ResetText();
            bindingSource1.DataSource = null;
            dataGridCallesLibres.Visible = false;
            if((Days) fechadateTimePicker1.Value.DayOfWeek != Days.Monday) {
                MessageBox.Show("Seleccione un lunes");

            }
            else
            {
                
            }
        }

        private void fechadateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ((Days)fechadateTimePicker1.Value.DayOfWeek != Days.Monday)
            {
                MessageBox.Show("Seleccione un lunes");

            }
            else if (piscinascomboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una piscina");
            }

            else
            {
                Pool selected = service.findPoolById(Convert.ToInt32(piscinascomboBox1.Text));
                IList<String> lista = service.listarCallesLibres(selected, fechadateTimePicker1.Value);
                BindingList<object> bindinglist = new BindingList<object>();
                for (int i = 0; i < lista.Count - 7; i += 7)
                {
                    bindinglist.Add(new
                    {
                        ds_h = lista.ElementAt(i),
                        ds_l = lista.ElementAt(i + 1),
                        ds_m = lista.ElementAt(i + 2),
                        ds_x = lista.ElementAt(i + 3),
                        ds_j = lista.ElementAt(i + 4),
                        ds_v = lista.ElementAt(i + 5),
                        ds_s = lista.ElementAt(i + 6)
                    });

                }

                bindingSource1.DataSource = bindinglist;
                dataGridCallesLibres.MultiSelect = false;
                dataGridCallesLibres.AllowUserToAddRows = false;
                dataGridCallesLibres.Visible = true;
            }
        }

        private void dataGridCallesLibres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void piscinascomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Days)fechadateTimePicker1.Value.DayOfWeek != Days.Monday)
            {
                MessageBox.Show("Seleccione un lunes");

            }

            else
            {
                Pool selected = service.findPoolById(Convert.ToInt32(piscinascomboBox1.Text));
                IList<String> lista = service.listarCallesLibres(selected, fechadateTimePicker1.Value);
                BindingList<object> bindinglist = new BindingList<object>();
                foreach (String s in lista)
                {
                    bindinglist.Add(s);
                }
                bindingSource1.DataSource = bindinglist;
                dataGridCallesLibres.MultiSelect = false;
                dataGridCallesLibres.AllowUserToAddRows = false;
                dataGridCallesLibres.Visible = true;
            }
            
        }

        
    }
    }
