using GestDepLib.Entities;
using GestDepLib.Persistence;
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
    public partial class AsignarMonitorACursillo : Form1
    {


        public AsignarMonitorACursillo(IGestDepService service) : base(service)
        {
            InitializeComponent();
            LoadData();

        }


        public void LoadData()
        {
            cursillodataGridView1.Visible = false;
            IList<Course> cursos = service.AllCourse();
            cursillocomboBox1.Items.Clear();
            if(cursos != null)
                foreach(Course c in cursos)
                    cursillocomboBox1.Items.Add(c.Description);
            cursillocomboBox1.SelectedIndex = -1;
            cursillocomboBox1.ResetText();

        }

        private void cursillocomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cursillodataGridView1.Visible = true;
            string nombre = (string)cursillocomboBox1.SelectedItem;
            Course c = service.findCourseByName(nombre);
            BindingList<Course> bindinglist = new BindingList<Course>();
            bindinglist.Add(c);
            coursesBindingSource1.DataSource = bindinglist;
            IList<Monitor> monitores = service.AllMonitors();
            monitorcomboBox2.Items.Clear();
            foreach (Monitor m in monitores)
            {
                monitorcomboBox2.Items.Add(m.Id);
            }
            monitorcomboBox2.SelectedIndex = -1;
            monitorcomboBox2.ResetText();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cursillocomboBox1.SelectedItem == null) 
            {
                MessageBox.Show("No se ha seleccionado cursillo");
            }
            else if (monitorcomboBox2.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado monitor");
            }
            else
            {
                IList<Course> cursos = service.AllCourse();
                foreach(Course c in cursos)
                {
                    if(c == coursesBindingSource1.Current)
                    {
                        Monitor m = service.findMonitorById((string)monitorcomboBox2.SelectedItem);
                        //c.setMonitor(m);
                        if (c.Monitor == null)
                        {
                            foreach (Course course in m.Courses)
                            {
                                if (course.StartDate.CompareTo(c.StartDate) == 0
                                    || course.FinishDate.CompareTo(c.StartDate) > 0
                                    || course.StartDate.CompareTo(c.FinishDate) < 0)
                                {
                                    //coursedays
                                    foreach (Days day in Enum.GetValues(typeof(Days)))
                                    {
                                        if ((course.CourseDays & c.CourseDays & day) == day)
                                        {
                                            if (course.StartHour.Equals(c.StartHour))
                                            {
                                                //throw new ServiceException("El curso empieza a la vez que otro, monitor ocupado");
                                                MessageBox.Show("El curso empieza a la vez que otro, monitor ocupado");
                                                return;
                                            }

                                            else
                                            {
                                                if (course.StartHour.Add(course.Duration).CompareTo(c.StartHour) > 0)
                                                {
                                                    //throw new ServiceException("Hay un curso impartiéndose, monitor ocupado");
                                                    MessageBox.Show("Hay un curso impartiéndose, monitor ocupado");
                                                    return;
                                                }
                                                else if (c.StartHour.Add(c.Duration).CompareTo(course.StartHour) > 0)
                                                {
                                                    //throw new ServiceException("Un monitor ya tiene un curso en ese intervalo de tiempo");
                                                    MessageBox.Show("Un monitor ya tiene un curso en ese intervalo de tiempo");
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            c.Monitor = m;
                            service.saveChanges();
                        }
                        else
                        { //throw new ServiceException("Ya hay un monitor impartiendo el curso."); 
                            MessageBox.Show("Ya hay un monitor impartiendo el curso.");
                            return;    
                        }
                        this.Close();
                    }
                }
                
            }
             
        }

        private void AsignarMonitorACursillo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestDepDemo02DataSet1.Courses' Puede moverla o quitarla según sea necesario.
            this.coursesTableAdapter.Fill(this.gestDepDemo02DataSet1.Courses);

        }
    }
}
