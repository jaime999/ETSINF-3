using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestDepLib.Entities;
using GestDepLib.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto.GUI
{
    public partial class AñadirCurso : Form
    {
        protected GestDepService gestDepService;
        private readonly object IDtextBox;
        private readonly object CursotextBox;
        private readonly object NombretextBox;

        public AñadirCurso(Course c)
        {
            gestDepService.addCourse(c);

        }

        protected virtual bool fieldsOk()
        {
            return
                !string.IsNullOrEmpty(IDTextBox.Text) &&
                !string.IsNullOrEmpty(NombretextBox.Text) &&
                !string.IsNullOrEmpty(CursotextBox.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (fieldsOk())
            {
                int anInteger;
                anInteger = Convert.ToInt32(IDtextBox.Text);
                anInteger = int.Parse(IDtextBox.Text);
                Course Sc = new Course(anInteger, NombretextBox.Text, CursotextBox.Text);
                try
                {
                    gestDepService.addCourse(Sc);
                    MessageBox.Show("Curso añadido", "Felicidades");
                    if (DarDeAltaCurso != null)
                        DarDEAltaCurso.InitializeCollections();
                }
                catch (Exception exc) { MessageBox.Show("Curso ya creado", "Error"); };

            }

            else MessageBox.Show("Hay campos sin rellenar", "Error");
        }
        private void addCourse()
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(IDtextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Añadir unicamente numeros.");
                IDtextBox_textChanged.Remove(IDtextBox.Text.Length - 1);
            }

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}

