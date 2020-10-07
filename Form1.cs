using System;
using System.Windows.Forms;

namespace PracticaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Saludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saludos, programas y usuarios");
        }

        private void Rojo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy un bello Rojo carmesí");
        }

        private void Naranja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy Naranja");
        }

        private void Amarillo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy Amarillo patito");
        }

        private void Verde_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy Verde");
        }

        private void Azul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy Azul");
        }

        private void Morado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy el color más varonil de todos: el Morado");
        }

        private void Rosado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy Rosado");
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
