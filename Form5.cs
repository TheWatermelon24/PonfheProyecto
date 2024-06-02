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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int op = 0;
            int tr, exa, cal, tre;
            double par1, par2, par3, calf;
            par1 = 0;
            par2 = 0;
            par3 = 0;
            do
            {
                op = int.Parse(Interaction.InputBox("Dame una opción:" +
                    "\n1.Calificación de parcial" +
                    "\n2.Semestre" +
                    "\n0.Salir"));
                switch (op)
                {
                    case 1:
                        tr = int.Parse(Interaction.InputBox("Cuántas tareas dejo el maestro"));
                        tre = int.Parse(Interaction.InputBox("Cuántas de ellas entrgaste"));

                        if (tre == tr)
                        {
                            MessageBox.Show("Por entregar todas las actividades tendras 2 puntos si apruebas el examen");
                            exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
                            if (exa >= 6)
                            {
                                MessageBox.Show("Puedes tener 2 puntos sí es que los necesitas");
                                cal = exa + 2;
                                if (cal > 10)
                                {
                                    cal = 10;
                                    MessageBox.Show($"Tu calificación es de: {cal}");
                                }
                                else
                                {
                                    if (cal <= 10)
                                    {
                                        MessageBox.Show($"Tu calificación es de: {cal}");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show($"Como no aprobaste el examen no puedes obtener tus puntos, tu calificación es de: {exa}");
                            }
                        }
                        else
                        {
                            if (tre > tr)
                            {
                                MessageBox.Show("No puedes entregar más actividades de las que pidió el maestro");
                            }
                            if (tre < tr)
                            {
                                MessageBox.Show("No entregaste todas las actividades, no tendras 2 puntos");
                                exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
                                MessageBox.Show($"Tú calificación es de {exa}");
                            }
                        }
                        break;
                    case 2:
                        MessageBox.Show("Bienvenido al programa de calificación de parcial");
                        do
                        {
                            par1 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 1"));
                            if (par1 > 10 || par1 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par1 > 10 || par1 < 0);
                        do
                        {
                            par2 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 2"));
                            if (par2 > 10 || par2 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par2 > 10 || par2 < 0);
                        do
                        {
                            par3 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 3"));
                            if (par3 > 10 || par3 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par3 > 10 || par3 < 0);

                        calf = (par1 + par2 + par3) / 3;

                        MessageBox.Show($"Tu calificación final es de {calf}");
                        break;
                    case 0:
                        MessageBox.Show("Gracias por usar el programa");
                        break;
                    default:
                        MessageBox.Show("Por favor usa una opción que este disponible");
                        break;
                }
            } while (op != 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int op = 0;
            int tr, exa, cal, tre;
            double par1, par2, par3, calf;
            par1 = 0;
            par2 = 0;
            par3 = 0;
            do
            {
                op = int.Parse(Interaction.InputBox("Dame una opción:" +
                    "\n1.Calificación de parcial" +
                    "\n2.Semestre" +
                    "\n0.Salir"));
                switch (op)
                {
                    case 1:
                        tr = int.Parse(Interaction.InputBox("Cuántas tareas dejo el maestro"));
                        tre = int.Parse(Interaction.InputBox("Cuántas de ellas entrgaste"));

                        if (tre == tr)
                        {
                            MessageBox.Show("Por entregar todas las actividades tendras 2 puntos si apruebas el examen");
                            exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
                            if (exa >= 6)
                            {
                                MessageBox.Show("Puedes tener 2 puntos sí es que los necesitas");
                                cal = exa + 2;
                                if (cal > 10)
                                {
                                    cal = 10;
                                    MessageBox.Show($"Tu calificación es de: {cal}");
                                }
                                else
                                {
                                    if (cal <= 10)
                                    {
                                        MessageBox.Show($"Tu calificación es de: {cal}");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show($"Como no aprobaste el examen no puedes obtener tus puntos, tu calificación es de: {exa}");
                            }
                        }
                        else
                        {
                            if (tre > tr)
                            {
                                MessageBox.Show("No puedes entregar más actividades de las que pidió el maestro");
                            }
                            if (tre < tr)
                            {
                                MessageBox.Show("No entregaste todas las actividades, no tendras 2 puntos");
                                exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
                                MessageBox.Show($"Tú calificación es de {exa}");
                            }
                        }
                        break;
                    case 2:
                        MessageBox.Show("Bienvenido al programa de calificación de parcial");
                        do
                        {
                            par1 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 1"));
                            if (par1 > 10 || par1 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par1 > 10 || par1 < 0);
                        do
                        {
                            par2 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 2"));
                            if (par2 > 10 || par2 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par2 > 10 || par2 < 0);
                        do
                        {
                            par3 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 3"));
                            if (par3 > 10 || par3 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par3 > 10 || par3 < 0);

                        calf = (par1 + par2 + par3) / 3;

                        MessageBox.Show($"Tu calificación final es de {calf}");
                        break;
                    case 0:
                        MessageBox.Show("Gracias por usar el programa");
                        break;
                    default:
                        MessageBox.Show("Por favor usa una opción que este disponible");
                        break;
                }
            } while (op != 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int op = 0;
            int tr, exa, cal, tre;
            double par1, par2, par3, calf;
            par1 = 0;
            par2 = 0;
            par3 = 0;
            do
            {
                op = int.Parse(Interaction.InputBox("Dame una opción:" +
                    "\n1.Calificación de parcial" +
                    "\n2.Semestre" +
                    "\n0.Salir"));
                switch (op)
                {
                    case 1:
                        tr = int.Parse(Interaction.InputBox("Cuántas tareas dejo el maestro"));
                        tre = int.Parse(Interaction.InputBox("Cuántas de ellas entrgaste"));

                        if (tre == tr)
                        {
                            MessageBox.Show("Por entregar todas las actividades tendras 2 puntos si apruebas el examen");
                            exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
                            if (exa >= 6)
                            {
                                MessageBox.Show("Puedes tener 2 puntos sí es que los necesitas");
                                cal = exa + 2;
                                if (cal > 10)
                                {
                                    cal = 10;
                                    MessageBox.Show($"Tu calificación es de: {cal}");
                                }
                                else
                                {
                                    if (cal <= 10)
                                    {
                                        MessageBox.Show($"Tu calificación es de: {cal}");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show($"Como no aprobaste el examen no puedes obtener tus puntos, tu calificación es de: {exa}");
                            }
                        }
                        else
                        {
                            if (tre > tr)
                            {
                                MessageBox.Show("No puedes entregar más actividades de las que pidió el maestro");
                            }
                            if (tre < tr)
                            {
                                MessageBox.Show("No entregaste todas las actividades, no tendras 2 puntos");
                                exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
                                MessageBox.Show($"Tú calificación es de {exa}");
                            }
                        }
                        break;
                    case 2:
                        MessageBox.Show("Bienvenido al programa de calificación de parcial");
                        do
                        {
                            par1 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 1"));
                            if (par1 > 10 || par1 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par1 > 10 || par1 < 0);
                        do
                        {
                            par2 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 2"));
                            if (par2 > 10 || par2 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par2 > 10 || par2 < 0);
                        do
                        {
                            par3 = double.Parse(Interaction.InputBox("Dame tu calificación del parcial 3"));
                            if (par3 > 10 || par3 < 0)
                            {
                                MessageBox.Show("Ingresa un valor de 0 a 10 por favor");
                            }
                        } while (par3 > 10 || par3 < 0);

                        calf = (par1 + par2 + par3) / 3;

                        MessageBox.Show($"Tu calificación final es de {calf}");
                        break;
                    case 0:
                        MessageBox.Show("Gracias por usar el programa");
                        break;
                    default:
                        MessageBox.Show("Por favor usa una opción que este disponible");
                        break;
                }
            } while (op != 0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int op = 0;
            do
            {

            } while (op != 0);
        }
    }
}
