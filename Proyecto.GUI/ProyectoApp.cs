using GestDepLib.Services;
using GestDepLib.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto.GUI
{
    public partial class ProyectoApp : Form
    {

            private GestDepService gestDepService;
            public ProyectoApp()
            {
                InitializeComponent();
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                bindingSource1.DataSource = null;
                bindingSource2.DataSource = null;
                bindingSource3.DataSource = null;
                bindingSource4.DataSource = null;
                label2.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void toolStripMenuItem2_Click(object sender, EventArgs e)
            {

            }

            private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
            {

            }

            private void añadirUnCursoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AñadirCurso frm = new AñadirCurso(null);
                frm.Show();
            }

            private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                gestDepService.removeAllData();
                //Example of Reservation creation by code
                /*
                User st = new User("223741947", "Guillermo Cortina Rodriguez", "Calle Valencia 1", 46010, "123456789");
                Course sc = new Course(1, "Curso de Mariposa", "Nadar");
                Course sc2 = new Course(2, "Curso de reanimacion", "Medicina");

                TaughtCourse tc1 = new TaughtCourse(1, DateTime.Now, DateTime.Now, "Lunes", 20, 60, 100, sc);
                TaughtCourse tc2 = new TaughtCourse(2, DateTime.Now, DateTime.Now, "Martes", 200, 600, 1000, sc);
                Teacher th = new Teacher("1", "Oscar Ramon", "Camino de Vera s/n", 46022, "SSN");
                Teacher th2 = new Teacher("2", "Virginia Olmedo", "Camino de Vera s/n", 46022, "SSN");
                Teacher th3 = new Teacher("3", "Sara Pastor", "Camino de Vera s/n", 46022, "SSN");

                Enrollment En = new Enrollment(5, DateTime.Now, DateTime.Now, true, st, tc1);

    
                busisnesscontrol.addStudent(st);
                busisnesscontrol.addCourse(sc);
                busisnesscontrol.addCourse(sc2);
                busisnesscontrol.addTaughtCourse(tc1);
                busisnesscontrol.addTaughtCourse(tc2);
                busisnesscontrol.addTeacher(th);
                busisnesscontrol.addTeacher(th2);
                busisnesscontrol.addTeacher(th3);
                busisnesscontrol.addEnrollment(En);
                MessageBox.Show("Archivos de EJEMPLO cargados", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    */
            }

            private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void añadirEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AsignarEstudianteACurso frm = new AsignarEstudianteACurso();
                frm.Show();
            }

            private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DarAltaCurso frm = new DarAltaCurso();
                frm.Show();
            }

            private void listarEstudiantesYCursosToolStripMenuItem_Click(object sender, EventArgs e)
            {

                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                label2.Visible = true;
                label1.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                ICollection<Course> cs = busisnesscontrol.findAllCourses();
                BindingList<object> bindinglist = new BindingList<object>();
                foreach (Course r in cs)
                    bindinglist.Add(new
                    {
                        ds_id = r.Id,
                        ds_name = r.Name,
                        ds_desc = r.Description,

                    });

                bindingSource1.DataSource = bindinglist;
                ICollection<Student> sc = busisnesscontrol.findAllStudents();

                BindingList<object> bindinglist2 = new BindingList<object>();
                foreach (Student r in sc)

                    //Adding one anonymous object for each reservation obtained
                    bindinglist2.Add(new
                    {
                        //ds_... are DataPropertyNames defined in the DataGridView object
                        //see DataGridView column definitions in Visual Studio Designer
                        dc_id = r.Id,
                        dc_name = r.Name,
                        dc_direccion = r.Address,
                        dc_zip = r.ZipCode,
                        dc_ibam = r.IBAN,

                    });

                bindingSource2.DataSource = bindinglist2;
            }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {


            }


            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void asignarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AsignarProfesor frm = new AsignarProfesor();
                frm.Show();
            }

            private void quitarListasToolStripMenuItem_Click(object sender, EventArgs e)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                label2.Visible = false;
                label1.Visible = false;

            }

            private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void listarProfesoresYEnrrollmentToolStripMenuItem_Click(object sender, EventArgs e)
            {
                dataGridView3.Visible = true;
                dataGridView4.Visible = true;
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;

                ICollection<TaughtCourse> tc = busisnesscontrol.findAllTaughtCourse();

                BindingList<object> bindinglist3 = new BindingList<object>();
                foreach (TaughtCourse r in tc)

                    //Adding one anonymous object for each reservation obtained
                    bindinglist3.Add(new
                    {
                        //ds_... are DataPropertyNames defined in the DataGridView object
                        //see DataGridView column definitions in Visual Studio Designer
                        dtc_id = r.Id,
                        dtc_End = r.EndTime,
                        dtc_quota = r.Quota,
                        dtc_duracion = r.SessionDuration,
                        dtc_start = r.StartDateTime,
                        dtc_DiaSemana = r.TeachingDay,
                        dtc_precio = r.TotalPrice,

                    });

                bindingSource3.DataSource = bindinglist3;
                ICollection<Teacher> ct = busisnesscontrol.findAllTeachers();

                BindingList<object> bindinglist4 = new BindingList<object>();
                foreach (Teacher r in ct)

                    //Adding one anonymous object for each reservation obtained
                    bindinglist4.Add(new
                    {
                        //ds_... are DataPropertyNames defined in the DataGridView object
                        //see DataGridView column definitions in Visual Studio Designer
                        dct_id = r.Id,
                        dct_name = r.Name,
                        dct_direccion = r.Address,
                        dct_zip = r.ZipCode,
                        dct_ssn = r.Ssn,

                    });

                bindingSource4.DataSource = bindinglist4;
            }

            private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void quitarListasProfesoresYEnrrollmentToolStripMenuItem_Click(object sender, EventArgs e)
            {
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }

            private void bindingSource4_CurrentChanged(object sender, EventArgs e)
            {

            }

            private void añadirEstudainteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AñadirEstudiante frm = new AñadirEstudiante(null);
                frm.Show();
            }

            private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
            {

            }
        }
    }


