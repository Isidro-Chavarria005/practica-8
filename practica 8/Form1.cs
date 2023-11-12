using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.MonthCalendar;

namespace practica_8
{
    public partial class Form1 : Form
    {
        private object radioCirc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * radio1 * radio1 * radio1;
            textBox2.Text = area1.ToString();
            textBox3.Text = volumen1.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            double base1, altura1, area1;
            base1 = double. Parse(textBox4.Text);
            altura1 = double. Parse(textBox5.Text);
            area1 = base1 * altura1 / 2;
            textBox5.Text = altura1.ToString();
            textBox6.Text = area1.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lado1, area1, volumen1;
            lado1 = double.Parse(textBox7.Text);
            volumen1 = lado1 * lado1 * lado1;
            area1 = 6 * (lado1 * lado1);
            textBox9.Text = volumen1.ToString();
            textBox8.Text = area1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1, altura1;
            altura1 = double.Parse(textBox13.Text);
            radio1 = double.Parse(textBox10.Text);
            area1 = 2 * pi * radio1 * (radio1 + altura1);
            volumen1 = pi * (radio1 * radio1) * altura1; 
            textBox11.Text = area1.ToString();
            textBox12.Text = volumen1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double diagonal1, area1, diagonal2;
            diagonal1 = double.Parse(textBox14.Text);
            diagonal2 = double.Parse(textBox15.Text);
            area1 = diagonal1 * diagonal2 / 2;
            textBox16.Text = area1.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double lado1, area1, volumen1;
            lado1 = double.Parse(textBox17.Text);
            area1 = 2 * 1.73 * (lado1 * lado1);
            volumen1 = (1.41 / 3) * lado1 * lado1 * lado1; 
            textBox18.Text = area1.ToString();
            textBox19.Text = volumen1.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

