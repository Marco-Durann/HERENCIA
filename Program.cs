﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    /*clase principal o clase para guardar los elemento sde lectura
       de valores y almacenando de valores en variables*/
  //nombre de la calse  
     class operacion
        {
            //declaracion de variable que se usa en clase
            //tipo de acceso            tipo de dato             nombre de dato
            protected                   int                      valor1;
            protected                   int                      valor2;
            protected                   int                      resultado;

            //atributos de la clase opreacion
            //metodos o funciones de las operaciones
            //*los metodos que se ponen a continuacion
            //*son las funciones de obtener el valor 
            //*de la caja de texto y guardarlo en la 
            //*memoria dentro de la variable indicada */
            //constructor de dato valor1

            public int Valor1
            {
                get { return valor1; } // vamos por el valor de la caja de texto 
                set { valor1 = value; } // lo guardamos en memoria 
            }
            public int Valor2
            {
                get { return valor2; } // vamos por el valor de la caja de texto
                set { valor2 = value; } // lo guardamos en memoria 
            }
            public int Resultado
            {
                get { return resultado; }// vamos por el valor de la caja de texto 
                set { resultado = value } // lo guardamos en memoria 
            }
    }
    //Creamos nuestra clase hijo que usara los 
    //metodos de crear dato
    class Sumar : operacion // los : nos dan permiso de usar lo que tiene operacion 
    {
                //las clases hijas tambien pueden tener sus propios atributos y metodos 
                //pueden tener variables de uso solamente para la clase hijo 
                // declarar variables de esta clase
                // atributos de esta clase 
                //metodos de clase 
                public int operar(int v1, int v2)
                {
                    valor1 = v1;
                    valor2 = v2;
                    return resultado = valor1 + valor2;
                }
     }
            class Resta : operacion // los : nos dan permiso de usar lo que tiene operacion 
            {
                //las clases hijas tambien pueden tener sus propios atributos y metodos 
                //pueden tener variables de uso solamente para la clase hijo 
                // declarar variables de esta clase
                // atributos de esta clase 
                //metodos de clase 

                public int operar(int v1, int v2)
                {
                    valor1 = v1;
                    valor2 = v2;
                    return resultado = valor1 - valor2;
                }
            }
            class Multiplicar : operacion // los : nos dan permiso de usar lo que tiene operacion 
            {
                //las clases hijas tambien pueden tener sus propios atributos y metodos 
                //pueden tener variables de uso solamente para la clase hijo 
                // declarar variables de esta clase
                // atributos de esta clase 
                //metodos de clase 
                public int operar(int v1, int v2)
                {
                    valor1 = v1;
                    valor2 = v2;
                    return resultado = valor1 * valor2;
                }
            }
    static class Program
    {
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
