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
    public partial class ListarAusencias : Form1
    {
        protected GestDepService gestDepService;

        public ListarAusencias(IGestDepService service) : base(service)
        {
            InitializeComponent();
            noAbs.Hide();
            BindingList<object> bindinglist = new BindingList<object>();
            IList<Course> course = service.AllCourse();
            foreach (Course c in course)
            {
                bindinglist.Add(c);
            }
            coursesBindingSource.DataSource = bindinglist;

            CoursesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CoursesTable.MultiSelect = false;
            CoursesTable.AllowUserToAddRows = false;

            absencesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            absencesTable.MultiSelect = false;
            absencesTable.AllowUserToAddRows = false;
        }
        private void CoursesTable_SelectionChanged(object sender, EventArgs e)
        {
            /*noAbs.Hide();
            Course courseSelected = null;
            int selectedrowindex = CoursesTable.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = CoursesTable.Rows[selectedrowindex];
            courseSelected = (Course)CoursesTable.CurrentRow.DataBoundItem;
            BindingList<object> bindinglist = new BindingList<object>();
            ICollection<Enrollment> enrollments =  courseSelected.Enrollments;
            foreach (Enrollment enro in enrollments)
            {
                User u = enro.User;
                ICollection<Absence> absencesEnrollment = enro.Absences;
                BindingList<Absence> bindingList = new BindingList<Absence>();
                IList<Absence> listaAusencias = service.AllAbsences();
                foreach (Absence a in absencesEnrollment)
                {
                    bindingList.Add(a);
                }

                bindingSourceAbsences.DataSource = bindinglist;
                if (bindinglist.Count == 0)
                {
                    noAbs.Show();
                }

            }
            */
        }

        private void CoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void bindingSourceAbsences_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ListarAusencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestDepDemo02DataSet2.Absences' Puede moverla o quitarla según sea necesario.
            //this.coursesTableAdapter.Fill(this.gestDepDemo02DataSet1.Courses);

            //this.absencesTableAdapter.Fill(this.gestDepDemo02DataSet2.Absences);
        }

        private void absencesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            Course courseSelected = null;
            int selectedrowindex = CoursesTable.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = CoursesTable.Rows[selectedrowindex];
            courseSelected = (Course)CoursesTable.CurrentRow.DataBoundItem;
            BindingList<Absence> bindingList = new BindingList<Absence>();
            IList<Absence> listaAusencias = service.listarFaltasPorCurso(courseSelected);
            foreach (Absence a in listaAusencias)
            {
                bindingList.Add(a);
            }
            if (bindingList.Count == 0)
            {
                noAbs.Show();
                absencesBindingSource.DataSource = bindingList;
            }
            else
            {
                noAbs.Hide();
                absencesBindingSource.DataSource = bindingList;
            }
        }
    }
}

