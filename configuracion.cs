using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class configuracion : Form
    {
        public configuracion()
        {
            InitializeComponent();
            // 1 BLANCO
            // 2 ROJO
            // 3 AMARILLO
            // 4 VERDE
            // 5 NEGRO
        }

        private void configuracion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            juego.colorfondo = 1;
            MessageBox.Show("Color Blanco Establecido");
        }

        private void ShowDialog(string v)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            juego.colorfondo = 2;
            MessageBox.Show("Color Rojo Establecido");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            juego.colorfondo = 3;
            MessageBox.Show("Color Amarillo Establecido");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            juego.colorfondo = 4;
            MessageBox.Show("Color Verde Establecido");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            juego.colorfondo = 5;
            MessageBox.Show("Color Negro Establecido");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juego.chcolor = 1;
            configuracion configuracion = new configuracion();
            this.Close();

        }
    }
}
