using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestDepLib.BusinessLogic;
using GestDepLib.Entities;
using GestDepLib.Persistence;
using GestDepLib.Services;

namespace WindowsFormsApplication1
{
    public partial class AsignarEstudianteACurso : Form
    {
        private GestDepService gestDepService;
        private List<Course> cursos;
        public AsignarEstudianteACurso(DateTime dateTime, User u, Course c)
        {
            InitializeComponent();
            gestDepService.enrollUserToCourse(dateTime, u, c);
            InitializeCollections();


        }
        public void InitializeCollections()
        {
            cursos = cursos.FindAll();
            foreach (Course t in cursos)
            {
                CursoComboBox.Items.Add(t.ToString);
            }
            /*CursoComboBox.DisplayMember = "id";
            CursoComboBox.ValueMember = "id" ;
            CursoComboBox.DataSource = Businesscontrol.findAllTaughtCourse();
            CursoComboBox.SelectedIndex = -1;*/
        }
        protected virtual bool fieldsOk()
        {
            return
                !string.IsNullOrEmpty(DniTextBox.Text) &&
                !string.IsNullOrEmpty(CursoComboBox.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DniTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AsignarEstudianteACurso_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int x;
            String n = CursoComboBox.SelectedItem.ToString();
            n = n.Substring(0, 2);
            //x = Convert.ToInt32(CursoComboBox.SelectedItem);
            x = int.Parse(n);

            //Enrollment t = Businesscontrol.findEnrollmentById(dni);
            if (fieldsOk())
            {
                int dni;
                dni = Convert.ToInt32(DniTextBox.Text);
                dni = int.Parse(DniTextBox.Text);
                User p = gestDepService.findStudentById(DniTextBox.Text);
                Course y = gestDepService.findCourseByName(x);
                Enrollment t = gestDepService.findEnrollmentById(dni);
                if (p == null)
                {
                    /*Comprobar si el Studiante existe*/
                    MessageBox.Show("El estudiante no esta registrado, procede a añadirlo", "¡Cuidado!");
                    AñadirUsuario frm = new AñadirUsuario(this);
                    frm.Show();
                }
                else if (t != null)
                {
                    /*"Ver si el estudiante ya está en el curso"*/
                    MessageBox.Show("El Alumno ya está en el curso", "¡Cuidado!");

                }
                else
                {
                    /* Hacer inscripcion */
                    Enrollment Sc = new Enrollment(dni, y.StartDateTime, y.EndTime, true, p, y);

                    Businesscontrol.addEnrollment(Sc);

                    MessageBox.Show("Alumno añadido al curso", "Felicidades");
                }
            }
            else MessageBox.Show("Hay campos sin rellenar", "Error");
        }
    }
}
   
