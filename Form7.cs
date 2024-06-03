using Microsoft.VisualBasic;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal = 0, act = 0, acte = 0;
            act = double.Parse(Interaction.InputBox("Cuántas actividades que pidio el maestro"));
            do
            {
                acte = double.Parse(Interaction.InputBox("Cuántas actividades entregaste"));
                if (acte > act || acte < 0)
                {
                    MessageBox.Show("Ingresa un valor correcto");
                }
            } while (acte > act);
            cal = (acte / act) * 10;
            MessageBox.Show($"Tu calificación es {cal}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double act = 0, acte = 0, cal = 0;
            act = double.Parse(Interaction.InputBox("Cuántas actividades que pidio el maestro"));
            do
            {
                acte = double.Parse(Interaction.InputBox("Cuaántas actividades entregaste"));
                if (acte > act || acte < 0)
                {
                    MessageBox.Show("Ingresa un valor correcto");
                }
            } while (acte > act);
            cal = (acte / act) * 10;
            MessageBox.Show($"Tu calificación es {cal}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double act = 0, acte = 0, cal = 0;
            act = double.Parse(Interaction.InputBox("Cuántas actividades que pidio el maestro"));
            do
            {
                acte = double.Parse(Interaction.InputBox("Cuaántas actividades entregaste"));
                if (acte > act || acte < 0)
                {
                    MessageBox.Show("Ingresa un valor correcto");
                }
            } while (acte > act);
            cal = (acte / act) * 10;
            MessageBox.Show($"Tu calificación es {cal}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double op = 0, act = 0, acte = 0, cal = 0, act1 = 0, acte1 = 0, cal1 = 0;
            double act2 = 0, acte2 = 0, cal2 = 0;
            double calf = 0;
            do
            {
                op = double.Parse(Interaction.InputBox("Dame una opción:" +
                    "\n1.Parcial 1" +
                    "\n2.Parcial 2" +
                    "\n3.Parcial 3" +
                    "\n4.Semestre" +
                    "\n5.Salir"));
                switch (op)
                {
                    case 1:
                        act1 = double.Parse(Interaction.InputBox("Cuántas actividades que pidio el maestro"));
                        do
                        {
                            acte1 = double.Parse(Interaction.InputBox("Cuaántas actividades entregaste"));
                            if (acte1 > act1 || acte1 < 0)
                            {
                                MessageBox.Show("Ingresa un valor correcto");
                            }
                        } while (acte1 > act1);
                        cal1 = (acte1 / act1) * 10;
                        MessageBox.Show($"Tu calificación es {cal1}");
                        break;
                    case 2:
                        act = double.Parse(Interaction.InputBox("Cuántas actividades que pidio el maestro"));
                        do
                        {
                            acte1 = double.Parse(Interaction.InputBox("Cuaántas actividades entregaste"));
                            if (acte1 > act1 || acte1 < 0)
                            {
                                MessageBox.Show("Ingresa un valor correcto");
                            }
                        } while (acte > act);
                        cal1 = (acte1 / act1) * 10;
                        MessageBox.Show($"Tu calificación es {cal1}");
                        break;
                    case 3:
                        act2 = double.Parse(Interaction.InputBox("Cuántas actividades que pidio el maestro"));
                        do
                        {
                            acte2 = double.Parse(Interaction.InputBox("Cuaántas actividades entregaste"));
                            if (acte2 > act2 || acte2 < 0)
                            {
                                MessageBox.Show("Ingresa un valor correcto");
                            }
                        } while (acte2 > act2);
                        cal2 = (acte2 / act2) * 10;
                        MessageBox.Show($"Tu calificación es {cal2}");
                        break;
                    case 4:
                        calf = (cal + cal1 + cal2) / 3;
                        MessageBox.Show($"Tu calificación es {calf}");
                        break;
                    case 5:
                        MessageBox.Show("Gracias por salir");
                        break;
                }
                
                
            } while (op != 5);
        }
    }
}
