using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {

        Form2 ImplementaMenu;
        Form3 DiseñaMenu;
        Form4 CodificaMenu;
        Form5 MateMenu;
        Form6 ForMenu;
        Form7 CulMenu;
        Form8 quiMenu;
        Form9 LeoMenu;
        Form10 INglMenu;
        Form11 CiensMenu;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                ImplementaMenu = new Form2();
                ImplementaMenu.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiseñaMenu = new Form3();
            DiseñaMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CodificaMenu = new Form4();
            CodificaMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MateMenu = new Form5();
            MateMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForMenu = new Form6();
            ForMenu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CulMenu = new Form7();
            CulMenu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            quiMenu = new Form8();
            quiMenu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeoMenu = new Form9();
            LeoMenu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            INglMenu = new Form10();
            INglMenu.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CiensMenu = new Form11();
            CiensMenu.Show();
        }
    }
}
