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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user11.Text = "";
            user12.Text = "";
            user13.Text = "";
            user21.Text = "";
            user22.Text = "";
            user23.Text = "";
            user31.Text = "";
            user32.Text = "";
            user33.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            juego.equiscero_val = 1;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            juego.equiscero_val = 2;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user22.Text = "X";
            else
            {
                user22.Text = "O";
            }
        }

        private void user11_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user11.Text = "X";
            else
            {
                user11.Text = "O";
            }
        }

        private void user12_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user12.Text = "X";
            else
            {
                user12.Text = "O";
            }
        }

        private void user13_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user13.Text = "X";
            else
            {
                user13.Text = "O";
            }
        }

        private void user21_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user21.Text = "X";
            else
            {
                user21.Text = "O";
            }
        }

        private void user23_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user23.Text = "X";
            else
            {
                user23.Text = "O";
            }
        }

        private void user31_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user31.Text = "X";
            else
            {
                user31.Text = "O";
            }
        }

        private void user32_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user32.Text = "X";
            else
            {
                user32.Text = "O";
            }
        }

        private void user33_Click(object sender, EventArgs e)
        {
            if (juego.equiscero_val == 1)
                user33.Text = "X";
            else
            {
                user33.Text = "O";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            user11.Text = "";
            user12.Text = "";
            user13.Text = "";
            user21.Text = "";
            user22.Text = "";
            user23.Text = "";
            user31.Text = "";
            user32.Text = "";
            user33.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            comojugar comojugar = new comojugar();
            comojugar.Show();
        }
    }
}
