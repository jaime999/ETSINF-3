using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using GestDepLib.Services;
using GestDepLib.Persistence;

namespace WindowsFormsApplication1
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IGestDepService service = new GestDepService(new EntityFrameworkDAL(new GestDepDbContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaPrincipal(service));
        }
    }
}
