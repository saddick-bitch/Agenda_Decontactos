using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormContacto());
        }
    }
}
