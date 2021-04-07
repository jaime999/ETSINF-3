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
using GestDepLib.Persistence;

namespace Proyecto.GUI
{
    public partial class AñadirUsuario : Form
    {
        GestDepService gestDepService;
        public AñadirUsuario(User u)
        {
            InitializeComponent();
            gestDepService.addUser();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ProyectoApp frm = new ProyectoApp();
            frm.Show();
        }

        private void AñadirEstudiante_Load(object sender, EventArgs e)
        {

        }
        protected virtual bool fieldsOk()
        {
            return
                !string.IsNullOrEmpty(IDTextBox.Text) &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(IBANTextBox.Text) &&
                !string.IsNullOrEmpty(AddressTextBox.Text) &&
                !string.IsNullOrEmpty(ZipCodeTextBox.Text);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;


            if (fieldsOk())
            {
                User u = gestDepService.findStudentById(id);

                if (p != null)
                {
                    MessageBox.Show("Esta persona ya existe", "Error");

                }
                else //cambiar .text a integer
                {
                    int anInteger;
                    anInteger = Convert.ToInt32(ZipCodeTextBox.Text);
                    anInteger = int.Parse(ZipCodeTextBox.Text);
                    User u = new User(IDTextBox.Text, NameTextBox.Text, AddressTextBox.Text, anInteger, IBANTextBox.Text);
                    gestDepService.addUser(u);
                    MessageBox.Show("Estudiante añadido", "Alert");
                    if (AsignarEstudianteACurso != null) ;
                    //     AsignarEstudianteACurso.AñadirEstudiante();

                }
            }
            else MessageBox.Show("Hay campos sin rellenar del estudiante", "Error");

        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}