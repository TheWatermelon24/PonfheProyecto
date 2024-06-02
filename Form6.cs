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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int asi = 0;
            string acr;
            do
            {
                asi = int.Parse(Interaction.InputBox("Cuanto porcentaje de asistencia tuviste"));
                if (asi < 0 || asi > 100)
                {
                    MessageBox.Show("Por favor ingresa un valor de 0-100");
                }
                else
                {
                    if (asi == 100)
                    {
                        MessageBox.Show("Estas acreditado");
                        acr = "Acreditado";
                    }
                    if (asi < 100)
                    {
                        MessageBox.Show("Estas desacreditado");
                        acr = "Desacreditado";
                    }
                }
            } while (asi > 100 || asi < 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int asi = 0;
            string acr;
            do
            {
                asi = int.Parse(Interaction.InputBox("Cuanto porcentaje de asistencia tuviste"));
                if (asi < 0 || asi > 100)
                {
                    MessageBox.Show("Por favor ingresa un valor de 0-100");
                }
                else
                {
                    if (asi == 100)
                    {
                        MessageBox.Show("Estas acreditado");
                        acr = "Acreditado";
                    }
                    if (asi < 100)
                    {
                        MessageBox.Show("Estas desacreditado");
                        acr = "Desacreditado";
                    }
                }
            } while (asi > 100 || asi < 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int asi = 0;
            string acr;
            do
            {
                asi = int.Parse(Interaction.InputBox("Cuanto porcentaje de asistencia tuviste"));
                if (asi < 0 || asi > 100)
                {
                    MessageBox.Show("Por favor ingresa un valor de 0-100");
                }
                else
                {
                    if (asi == 100)
                    {
                        MessageBox.Show("Estas acreditado");
                        acr = "Acreditado";
                    }
                    if (asi < 100)
                    {
                        MessageBox.Show("Estas desacreditado");
                        acr = "Desacreditado";
                    }
                }
            } while (asi > 100 || asi < 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int op = 0, asi = 0, asi1 = 0, asi2 = 0;
            string acr = "Acreditado", acr1 = "Acreditado", acr2 = "Acreditado";
            do
            {
                op = int.Parse(Interaction.InputBox("Escoje una opción: " +
                    "\n1.Parcial 1" +
                    "\n2.Parcial 2" +
                    "\n3.Parcial 3" +
                    "\n4.Semestre" +
                    "\n5.Salir"));
                switch (op) {
                    case 1:
                        do
                        {
                            asi = int.Parse(Interaction.InputBox("Cuanto porcentaje de asistencia tuviste"));
                            if (asi < 0 || asi > 100)
                            {
                                MessageBox.Show("Por favor ingresa un valor de 0-100");
                            }
                            else
                            {
                                if (asi == 100)
                                {
                                    MessageBox.Show("Estas acreditado");
                                    acr = "Acreditado";
                                }
                                if (asi < 100)
                                {
                                    MessageBox.Show("Estas desacreditado");
                                    acr = "Desacreditado";
                                }
                            }
                        } while (asi > 100 || asi < 0);
                        break;
                    case 2:
                        do
                        {
                            asi1 = int.Parse(Interaction.InputBox("Cuanto porcentaje de asistencia tuviste"));
                            if (asi1 < 0 || asi1 > 100)
                            {
                                MessageBox.Show("Por favor ingresa un valor de 0-100");
                            }
                            else
                            {
                                if (asi1 == 100)
                                {
                                    MessageBox.Show("Estas acreditado");
                                    acr1 = "Acreditado";
                                }
                                if (asi1 < 100)
                                {
                                    MessageBox.Show("Estas desacreditado");
                                    acr1 = "Desacreditado";
                                }
                            }
                        } while (asi1 > 100 || asi1 < 0);
                        break;
                    case 3:
                        do
                        {
                            asi2 = int.Parse(Interaction.InputBox("Cuanto porcentaje de asistencia tuviste"));
                            if (asi2 < 0 || asi2 > 100)
                            {
                                MessageBox.Show("Por favor ingresa un valor de 0-100");
                            }
                            else
                            {
                                if (asi2 == 100)
                                {
                                    MessageBox.Show("Estas acreditado");
                                    acr2 = "Acreditado";
                                }
                                if (asi2 < 100)
                                {
                                    MessageBox.Show("Estas desacreditado");
                                    acr2 = "Desacreditado";
                                }
                            }
                        } while (asi2 > 100 || asi2 < 0);
                        break;
                    case 4:
                        if ((acr == "Acreditado" && acr1 == "Acreditado" && acr2 == "Acreditado") || (acr == "Acreditado" && acr1 == "Acreditado" && acr2 == "Desacreditado") || (acr == "Acreditado" && acr1 == "Desacreditado" && acr2 == "Acreditado") || (acr == "Desacreditado" && acr1 == "Acredtiado" && acr2 == "Acreditado"))
                        {
                            MessageBox.Show("Felicidades estas acreditado");
                        }
                        else
                        {
                            MessageBox.Show("Estas desacreditado");
                        }
                        break;
                    case 5:
                        MessageBox.Show("Saliste del programa");
                        break;
                }
            } while (op != 5);
        }
    }
}
