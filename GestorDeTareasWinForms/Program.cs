using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTareasWinForms
{
    internal static class Program
    {
        /// <summary>
        /// Funcionalidades de login y registro implementadas.
        /// Nueva funcionalidad: mensaje de bienvenida al iniciar la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show("Bienvenido al Gestor de Tareas", "Inicio de la aplicación");

            Application.Run(new Form1());
        }
    }
}