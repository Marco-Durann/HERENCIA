using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            //Voy a darle comportamiento a mi boton
            // Voy a utilizar mi clase hija sumar
            Sumar sumar = new Sumar();//instancie, o hicre un nuevo objeto suma
            //llamar al metodo de calse suma operar
            button6.Text = sumar.operar
                (int.Parse(button1.Text), int.Parse(button2.Text)).ToString();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            //Voy a darle comportamiento a mi boton
            // Voy a utilizar mi clase hija restar
            Resta restar = new Resta();//instancie, o hicre un nuevo objeto suma
            //llamar al metodo de calse suma operar
           button6.Text = restar.operar
                (int.Parse(button1.Text), int.Parse(button2.Text)).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.clear();
            button2.clear();
            button6.clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Voy a darle comportamiento a mi boton
            // Voy a utilizar mi clase hija restar
            Multiplicar multiplicar = new Multiplicar();//instancie, o hicre un nuevo objeto suma
                                       //llamar al metodo de calse suma operar
            button6.Text = multiplicar.operar
                 (int.Parse(button1.Text), int.Parse(button2.Text)).ToString();

        }
    }
}
