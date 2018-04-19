using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppOrga
{
    public partial class Form1 : Form
    {
        string movement;
        
        public Form1()
        {
            InitializeComponent();
            movement = "";
            cajaVelocidad.SelectedIndex = 0;
        }

        public string toBinary(int number) {

            string binary="";
            do
            {
                binary = number % 2 + binary;
                number = (int)number / 2;
            } while (number >= 2);
            if (number == 1) { binary = 1 + binary; }
            for (int t = binary.Length; t < 4;t++) {
                binary = 0 + binary;
            }
            
            return binary;
        }

        private void botonEjecutar_Click(object sender, EventArgs e)
        {
            if (movement == "")
            {
                MessageBox.Show("Se debe seleccionar un movimiento");
                return;
            }
            string speed = "";
            if (cajaVelocidad.SelectedIndex == 0) {
                speed = "11";

            } else if (cajaVelocidad.SelectedIndex == 1)
            {
                speed = "10";

            }else if (cajaVelocidad.SelectedIndex == 2) {
                speed = "00";

            }
            label6.Text = toBinary(Convert.ToInt32(cajaTiempo.Value)) + "--" + speed + "--" + movement;
        }

        private void botonArriba_Click(object sender, EventArgs e)
        {
            movement = "00";
        }

        private void botonDer_Click(object sender, EventArgs e)
        {
            movement = "01";
        }

        private void botonAbajo_Click(object sender, EventArgs e)
        {
            movement = "11";
        }

        private void botonIzq_Click(object sender, EventArgs e)
        {
            movement = "10";
        }
               
    }
}
