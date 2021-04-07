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
    public partial class AñadirAusencia : Form1
    {

        public AñadirAusencia() : base ()
        {
            InitializeComponent();
            LoadData();
        }

        public AñadirAusencia(IGestDepService service) : base(service)
        {
            InitializeComponent();
            LoadData();
            

        }

        public void LoadData()
        {
            tablaDeAbsences.Visible = false;
            AñadirButton.Visible = false;
            listaDeCursosBox.Items.Clear();
            listaUsuariosBox.Items.Clear();
            dniMonitorBox.Text = "";
        }

        public void AñadirButton_Click(object sender, EventArgs e)
        {
            
            Course course = (Course)listaDeCursosBox.SelectedItem;
            User user = (User)listaUsuariosBox.SelectedItem;
            Enrollment enroll = course.findEnrollment(user.Id);
            Absence a = new Absence(faltadateTimePicker1.Value.Date);
            IList<Absence> listaAusencias = service.listarFaltasDeUsuario((User)listaUsuariosBox.SelectedItem, (Course)listaDeCursosBox.SelectedItem);
            Absence res = new Absence();
            /*for(int i=0; i< listaAusencias.Count; i++)
            {
                if (listaAusencias[i].Equals(a))
                {
                    MessageBox.Show("Ya existe una ausencia a esa fecha");
                    res = a;
                }
            }*/

            foreach (Enrollment enr in course.Enrollments)
            {
                foreach (Absence absence in enr.Absences)
                {
                    if (absence.Date.CompareTo(a.Date) == 0)
                    {
                        res = absence;
                    }

                }
            }
            if (res.Date.CompareTo(a.Date) == 0)
            {
                MessageBox.Show("Ya existe una ausencia a esa fecha");
            }
            else
            {
                absencesBindingSource.Add(a);
                enroll.addAbsence(a);
                service.addAbsence(a);
                MessageBox.Show("Ausencia creada");
            }

        }

        private void cargarCursosButton_Click(object sender, EventArgs e)
        {
            listaDeCursosBox.Items.Clear();
            listaUsuariosBox.Items.Clear();
            string dni = dniMonitorBox.Text;
            listaDeCursosBox.DisplayMember = "Description";
            IList<Course> listaCursos = service.findCourseByDniMonitor(dni);
            foreach(Course c in listaCursos)
            {
                listaDeCursosBox.Items.Add(c);
            }
            listaDeCursosBox.SelectedIndex = -1;
            listaUsuariosBox.SelectedIndex = -1;
            
        }

        private void listaDeCursosBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaDeCursosBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)listaDeCursosBox.SelectedItem;
                listaUsuariosBox.DisplayMember = "Name";
                foreach(Enrollment enr in selectedCourse.Enrollments)
                {
                    listaUsuariosBox.Items.Add(enr.User);
                }
                listaUsuariosBox.SelectedIndex = -1;
            }
            
        }

        private void listaUsuariosBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaUsuariosBox.SelectedItem != null)
            {
                User selectedUsuario = (User)listaUsuariosBox.SelectedItem;
                Course selectedCourse = (Course)listaDeCursosBox.SelectedItem;
                tablaDeAbsences.Visible = true;
                AñadirButton.Visible = true;
                BindingList<Absence> bindingList = new BindingList<Absence>();
                IList<Absence> listaAusencias = service.listarFaltasDeUsuario(selectedUsuario, selectedCourse);
                foreach(Absence a in listaAusencias)
                {
                    bindingList.Add(a);
                }
                absencesBindingSource.DataSource = bindingList;
            }
        }

        private void AñadirAusencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestDepDemo02DataSet2.Absences' Puede moverla o quitarla según sea necesario.
            
        }

        private void tablaDeAbsences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            Absence absenceSelected = null;
            int selectedrowindex = tablaDeAbsences.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = tablaDeAbsences.Rows[selectedrowindex];
            absenceSelected = (Absence )tablaDeAbsences.CurrentRow.DataBoundItem;
            BindingList<Absence> bindingList = new BindingList<Absence>();
            service.deleteAbsence(absenceSelected);
            tablaDeAbsences.Rows.RemoveAt(selectedrowindex);
            MessageBox.Show("Ausencia borrada");


        }


    }
}
