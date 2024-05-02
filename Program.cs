using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    static class Program
    {
        /*clase principal o clase para guardar los elemento sde lectura
        de valores y almacenando de valores en variables*/
        class operacion
        {
            //declaracion de variable que se usa en clase
            //tipo de acceso            tipo de dato             nombre de dato
            protected                   int                      valor1;
            protected                   int                      valor2;
            protected                   int                      resultados;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
