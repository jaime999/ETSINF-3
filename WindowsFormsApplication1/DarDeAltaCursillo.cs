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
    public partial class DarDeAltaCursillo : Form1
    {
        public DarDeAltaCursillo() : base()
        {

            InitializeComponent();
            LoadData();
        }

        public DarDeAltaCursillo(IGestDepService service) : base(service)
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            IList<Pool> piscinas = service.AllPools();
            piscinacomboBox1.Items.Clear();
            if (piscinas != null)
                foreach (Pool p in piscinas)
                    piscinacomboBox1.Items.Add(p.Id);
            piscinacomboBox1.SelectedIndex = -1;
            piscinacomboBox1.ResetText();
        }
        protected virtual bool fieldsOK()
        {
            return
                !string.IsNullOrEmpty(preciotextBox2.Text) &&
                !string.IsNullOrEmpty(nombretextBox7.Text) &&
                !string.IsNullOrEmpty(minenrollmentstextBox1.Text) &&
                !string.IsNullOrEmpty(maxenrollmentstextBox1.Text);
            }

        public virtual void Clear()
        {
            preciotextBox2.Clear();
            nombretextBox7.Clear();
            minenrollmentstextBox1.Clear();
            maxenrollmentstextBox1.Clear();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (fieldsOK() && service.findCourseByName(nombretextBox7.Text) == null &&
                           callescheckedListBox1.CheckedItems.Count != 0 && diascheckedListBox1.CheckedItems.Count != 0
                           && fechacomienzodateTimePicker1.Value.CompareTo(fechafinalizaciondateTimePicker2.Value) <= 0
                           && Convert.ToInt32(minenrollmentstextBox1.Text) <= Convert.ToInt32(maxenrollmentstextBox1.Text))
                {
                    Course c = new Course(nombretextBox7.Text, false, (Days)diascheckedListBox1.SelectedItem, duraciondateTimePicker2.Value.TimeOfDay, fechafinalizaciondateTimePicker2.Value, Convert.ToInt32(maxenrollmentstextBox1.Text), Convert.ToInt32(minenrollmentstextBox1.Text), Convert.ToDouble(preciotextBox2.Text), fechacomienzodateTimePicker1.Value, horainiciodateTimePicker1.Value, null);
                    Pool p = service.findPoolById((int)piscinacomboBox1.SelectedItem);
                    for (int x = 0; x <= callescheckedListBox1.CheckedItems.Count - 1; x++)
                    {
                        Lane l1 = p.findLane((int)callescheckedListBox1.CheckedItems[x]);
                        c.addlane(l1);
                    }


                    foreach (Lane l in c.Lanes)
                    {
                        foreach (Course course in l.Courses)
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
                                            MessageBox.Show("El curso empieza a la vez que otro, hay calles ocupadas");
                                            return;
                                            //throw new ServiceException("El curso empieza a la vez que otro, hay líneas ocupadas");
                                        }

                                        else
                                        {
                                            if (course.StartHour.Add(course.Duration).CompareTo(c.StartHour) > 0)
                                            {
                                                MessageBox.Show("Hay un curso impartiéndose, hay líneas ocupadas");
                                                return;
                                                //throw new ServiceException("Hay un curso impartiéndose, hay líneas ocupadas");
                                            }
                                            else if (c.StartHour.Add(c.Duration).CompareTo(course.StartHour) > 0)
                                            {
                                                MessageBox.Show("Un curso ya ocupa las líneas en ese intervalo de tiempo");
                                                return;
                                                //throw new ServiceException("Un curso ya ocupa las líneas en ese intervalo de tiempo");
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }


                    service.addCourse(c);
                    MessageBox.Show("Curso creado");
                    this.Close();
                }
                else if (Convert.ToInt32(minenrollmentstextBox1.Text) > Convert.ToInt32(maxenrollmentstextBox1.Text))
                {
                    MessageBox.Show("El máximo de inscripciones debe de ser mayor que el mínimo de inscripciones");
                    return;
                }

                else if (fechacomienzodateTimePicker1.Value.CompareTo(fechafinalizaciondateTimePicker2.Value) > 0)
                {
                    MessageBox.Show("Fecha de comienzo tiene que ser anterior que fecha de finalización");
                    return;
                }

                else if (diascheckedListBox1.CheckedItems.Count != 0)
                {
                    MessageBox.Show("Seleccione un día de la semana");
                    return;
                }

                else if (callescheckedListBox1.CheckedItems.Count != 0)
                {
                    MessageBox.Show("Seleccione las calles");
                    return;
                }
                else if (service.findCourseByName(nombretextBox7.Text) != null)
                {
                    MessageBox.Show("Ya hay un curso con ese nombre");
                    return;
                }



                else if (!fieldsOK())
                {
                    MessageBox.Show("Faltan campos por completar");
                    return;
                }
            } catch (Exception)
            {
                MessageBox.Show("Datos incorrectos");
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void piscinacomboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Pool p = service.findPoolById(Convert.ToInt32(piscinacomboBox1.SelectedItem));
            foreach (Lane l in p.Lanes)
            {
                callescheckedListBox1.Items.Add(l.Number);
            }
        }
    }
}
