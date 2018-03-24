using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraLT
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Liebre liebre = new Liebre();
            Tortuga tortuga = new Tortuga();

            while (liebre.Pasos< 80 && tortuga.Pasos < 80)
            {
                liebre.Avanzar();
                tortuga.Avanzar();
                textBox1.Text += liebre.ToString()+" "+tortuga.ToString() + Environment.NewLine;
            }

            if (liebre.Pasos >= 80 && tortuga.Pasos >= 80)
            {
                textBox1.Text += "Empate!";
            }
            else
            {
                if (tortuga.Pasos >= 80)
                {
                    textBox1.Text += "Tortuga GANA!";
                }
                else
                {
                    textBox1.Text += "Liebre GANA!";

                }
            }

        }
    }
}
