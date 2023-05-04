using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClasePersona bello;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bello != null)
            {
                string texto = bello.getRut() + " | " + bello.getNombre() + " | " + bello.getNumero();
                label1.Text = texto;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            int numero = int.Parse(txtNumero.Text);

            bello = new ClasePersona(rut, nombre, numero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && bello != null)
            {
                int numero = int.Parse(textBox1.Text);
                bello.sumaNumero(numero);
                button1.PerformClick();
            }
        }
    }
}
