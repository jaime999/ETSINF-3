using GestDepLib.Entities;
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
    public partial class AñadirUsuario : Form1
    {
        public AñadirUsuario() : base ()
        {

            InitializeComponent();
        }

        public AñadirUsuario(IGestDepService service) : base (service)
        {
            InitializeComponent();
        }
        protected virtual bool fieldsOK()
        {
            return
                !string.IsNullOrEmpty(dnitextBox1.Text) &&
                !string.IsNullOrEmpty(addresstextBox2.Text) &&
                !string.IsNullOrEmpty(nametextBox3.Text) &&
                !string.IsNullOrEmpty(zipCodetextBox4.Text) &&
                !string.IsNullOrEmpty(ibantextBox5.Text);
        }
        public virtual void Clear()
        {
            dnitextBox1.Clear();
            addresstextBox2.Clear();
            nametextBox3.Clear();
            zipCodetextBox4.Clear();
            ibantextBox5.Clear();
        }
        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (fieldsOK())
                {
                    if (service.findUserByDni(dnitextBox1.Text) != null)
                    {
                        MessageBox.Show("Ya existe un usuario con este DNI");
                    }
                    else
                    {
                        User u = new User(dnitextBox1.Text, nametextBox3.Text, addresstextBox2.Text, Convert.ToInt32(zipCodetextBox4.Text), ibantextBox5.Text, birthDatedateTimePicker1.Value, false);
                        service.addUser(u);
                        MessageBox.Show("Usuario creado");
                        Clear();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Faltan campos por completar");
                }
            } catch (Exception)
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void birthDatedateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
