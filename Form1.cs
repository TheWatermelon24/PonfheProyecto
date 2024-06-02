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
    }
}
