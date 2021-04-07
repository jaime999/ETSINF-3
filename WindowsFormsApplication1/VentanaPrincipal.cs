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
    public partial class VentanaPrincipal : Form1
    {
        private DarDeAltaCursillo darDeAltaCursillo;
        private AsignarMonitorACursillo asignarMonitorACursillo;
        private InscribirUsuarioACursillo inscribirUsuarioACursillo;
        private ListarCallesLibres listarCallesLibres;
        private AñadirAusencia añadirAusencia;
        private ListarAusencias listarAusencias;

        public VentanaPrincipal(IGestDepService service) : base(service)
        {
            InitializeComponent();
            darDeAltaCursillo = new DarDeAltaCursillo(service);
            asignarMonitorACursillo = new AsignarMonitorACursillo(service);
            inscribirUsuarioACursillo = new InscribirUsuarioACursillo(service);
            listarCallesLibres = new ListarCallesLibres(service);
            añadirAusencia = new AñadirAusencia(service);
            listarAusencias = new ListarAusencias(service);
        }

        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darDeAltaCursillo.ShowDialog();
        }

        private void asignarMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignarMonitorACursillo.ShowDialog();
        }

        private void inscribirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inscribirUsuarioACursillo.ShowDialog();
        }

        private void listarCallesLibresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarCallesLibres.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void añadirAusenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirAusencia.ShowDialog();
        }

        private void listarAusenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarAusencias.ShowDialog();
        }
    }
}
