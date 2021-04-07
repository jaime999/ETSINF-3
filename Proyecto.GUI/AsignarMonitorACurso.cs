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
    public partial class AsignarProfesor : Form
    {
        private GestDepService gestDepService;

        public AsignarProfesor(Monitor m)
        {
            InitializeComponent();
            gestDepService.addMonitor(m);
            InitializeCollections();
        }
        public void InitializeCollections()
        {

            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = gestDepService.AllCourse();
            comboBox1.SelectedIndex = -1;


        }
        private void refrescar()
        {
            comboBox1.Refresh();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Refresh();
            TaughtCourse tc = comboBox1.SelectedItem as TaughtCourse;
            if (tc != null)
            {
                Course cur = tc.Course;
                IdBox.Text = cur.Id.ToString();
                NombreBox.Text = cur.Name;
                DescBox.Text = cur.Description;
                if (tc.Teacher != null) ProfesorBox.Text = tc.Teacher.Name;
                else ProfesorBox.Text = "";
                IDTextBox.Text = tc.Id.ToString();
                CuotaTextBox.Text = tc.Quota.ToString();
                DiaInicio.Text = tc.StartDateTime.Day.ToString();
                MesInicio.Text = tc.StartDateTime.Month.ToString();
                AnyoInicio.Text = tc.StartDateTime.Year.ToString();
                HoraInicio.Text = tc.StartDateTime.Hour.ToString();
                MinutosInicio.Text = tc.StartDateTime.Minute.ToString();
                HoraFin.Text = tc.EndTime.Hour.ToString();
                MinutosFin.Text = tc.EndTime.Minute.ToString();
                DuracionTextBox.Text = tc.SessionDuration.ToString();
                PrecioTextBox.Text = tc.TotalPrice.ToString();
                DiaImpartidoTextBox.Text = tc.TeachingDay.ToString();
                if (tc.Teacher != null)
                {
                    ProfesorBox.Text = tc.Teacher.Name;
                }

                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Name";
                comboBox2.DataSource = Businesscontrol.BuscarTeacher(tc);
                comboBox2.SelectedIndex = -1;
            }
            else
            {
                IdBox.Text = "";
                NombreBox.Text = "";
                DescBox.Text = "";
                ProfesorBox.Text = "";
                IDTextBox.Text = "";
                CuotaTextBox.Text = "";
                DiaInicio.Text = "";
                MesInicio.Text = "";
                AnyoInicio.Text = "";
                HoraInicio.Text = "";
                MinutosInicio.Text = "";
                HoraFin.Text = "";
                MinutosFin.Text = "";
                DuracionTextBox.Text = "";
                PrecioTextBox.Text = "";
                DiaImpartidoTextBox.Text = "";
                ProfesorBox.Text = "";


            }
        }

        private void AsignarProfesor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                String monitor = (comboBox2.SelectedItem as Monitor).Id;
                int curso = (comboBox1.SelectedItem as Course).Id;
                gestDepService.addMonitorToACourse(monitor, curso);
                MessageBox.Show("Profesor asignado al curso", "Felicidades");
                this.Hide();

            }
            else MessageBox.Show("Selecciona curso y profesor", "Error");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}