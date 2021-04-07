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
    public partial class InscribirUsuarioACursillo : Form1
    {
        private AñadirUsuario añadirUsuario;
        protected GestDepService gestDepService;
        public InscribirUsuarioACursillo(IGestDepService service) : base(service)
        {
            InitializeComponent();
            añadirUsuario = new AñadirUsuario(service);
            LoadData();

        }

        public  bool fieldsOK()
        {
            return !string.IsNullOrEmpty(dnitextBox1.Text);
        }
        public void LoadData()

        {
            label4.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            usuariodataGridView2.Visible = false;
            IList<Course> cursos = service.AllCourse();
            cursillocomboBox1.Items.Clear();
            if (cursos != null)
                foreach(Course c in cursos)
                        cursillocomboBox1.Items.Add(c.Description);
            cursillocomboBox1.SelectedIndex = -1;
            cursillocomboBox1.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fieldsOK())
            {
                if (cursillocomboBox1.SelectedItem != null)
                {
                    User u = service.findUserByDni(dnitextBox1.Text);
                    if (u != null)
                    {
                        Course c = service.findCourseByName(cursillocomboBox1.Text);
                        Enrollment enr = service.findEnrollmentByUserDni(u.Id);
                        if (enr.Course.Description == c.Description)
                        {
                            MessageBox.Show("Este usuario ya está asignado a este cursillo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            label5.Visible = true;
                            label4.Visible = true;
                            label3.Visible = true;
                            usuariodataGridView2.Visible = true;
                            BindingList<User> bindinglist = new BindingList<User>();
                            bindinglist.Add(u);
                            peopleBindingSource.DataSource = bindinglist;
                            label5.Text = Convert.ToString(c.Price);
                        }
                    }
                    else
                    {
                        DialogResult boton = MessageBox.Show("No hay ningún usuario con este DNI", "¿Inscribir Usuario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (boton == DialogResult.OK)
                        {
                            añadirUsuario.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Falta elegir el cursillo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u = service.findUserByDni(dnitextBox1.Text);
            Course c = service.findCourseByName(cursillocomboBox1.Text);
            service.enrollUserToCourse(DateTime.Today, u, c);
            Enrollment enr = service.findEnrollmentByUserDni(dnitextBox1.Text);
            service.addPayment(enr, DateTime.Today);
            MessageBox.Show("Inscripción confirmada, pago realizado.");
        }
    }
}
