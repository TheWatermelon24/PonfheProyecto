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
            int op = 0, tr = 0, tre = 0, exa = 0, cal = 0, tr1 = 0, tre1 = 0, exa1 = 0, cal1 = 0;
            int tr2 = 0, tre2 = 0, exa2 = 0, cal2 = 0, calf = 0;
            do
            {
                op = int.Parse(Interaction.InputBox("Selecciona una opción: " +
                    "\n1.Parcial 1" +
                    "\n2.Parcial 2" +
                    "\n3.Parcial 3" +
                    "\n4.Semestre" +
                    "\n0.Salir"));
                switch (op) {
                    case 1:
                        do
                        {
                            tr = int.Parse(Interaction.InputBox("Cuántas tareas pidio el mastro"));
                            tre = int.Parse(Interaction.InputBox("Cuántas entregaste"));
                            if (tre > tr || tre < 0)
                            {
                                MessageBox.Show("No puedes entregar más tareas de las que se piden, o no puedes entregar menos de 0 tareas");
                            }
                            else
                            {
                                if (tre == tr)
                                {
                                    
                                    MessageBox.Show("Tienes derecho a 2 puntos extra para tu calificación del examen");
                                    do
                                    {
                                        exa = int.Parse(Interaction.InputBox("Cuánto sacaste en el examen"));
                                        if (exa > 10 || exa < 0)
                                        {
                                            MessageBox.Show("Ingresa una calificación que sea del 0-10");
                                        }
                                        else
                                        {
                                        if (exa < 6)
                                            {
                                                cal = exa;
                                                MessageBox.Show($"Tú calificación es {cal}");
                                            }
                                        if (exa >= 6)
                                            {
                                                cal = exa + 2;
                                                if (cal > 10)
                                                {
                                                    cal = 10;
                                                    MessageBox.Show($"Tú calificación es {cal}");
                                                }else
                                                {
                                                    MessageBox.Show($"Tu calificación es {cal}");
                                                }
                                            }
                                        }
                                    } while (exa > 10 || exa < 0);
                                    
                                }
                                if (tre < tr)
                                {
                                    do
                                    {
                                        exa = int.Parse(Interaction.InputBox("Cuánto sacaste en el examen"));
                                        if (exa > 10 || exa < 0)
                                        {
                                            MessageBox.Show("Ingresa una califiación del 0-10");
                                        }else
                                        {
                                            cal = exa;
                                            MessageBox.Show($"Tu calificación es {cal}");
                                        }
                                    } while (exa > 10 || exa < 0);
                                  
                                }
                            }
                        } while (tre > tr || tre < 0);
                        break;
                    case 2:
                        do
                        {
                            tr1 = int.Parse(Interaction.InputBox("Cuántas tareas pidio el mastro"));
                            tre1 = int.Parse(Interaction.InputBox("Cuántas entregaste"));
                            if (tre1 > tr1 || tre1 < 0)
                            {
                                MessageBox.Show("No puedes entregar más tareas de las que se piden, o no puedes entregar menos de 0 tareas");
                            }
                            else
                            {
                                if (tre1 == tr1)
                                {

                                    MessageBox.Show("Tienes derecho a 2 puntos extra para tu calificación del examen");
                                    do
                                    {
                                        exa1 = int.Parse(Interaction.InputBox("Cuánto sacaste en el examen"));
                                        if (exa1 > 10 || exa1 < 0)
                                        {
                                            MessageBox.Show("Ingresa una calificación que sea del 0-10");
                                        }
                                        else
                                        {
                                            if (exa1 < 6)
                                            {
                                                cal1 = exa1;
                                                MessageBox.Show($"Tú calificación es {cal1}");
                                            }
                                            if (exa1 >= 6)
                                            {
                                                cal1 = exa1 + 2;
                                                if (cal1 > 10)
                                                {
                                                    cal1 = 10;
                                                    MessageBox.Show($"Tú calificación es {cal1}");
                                                }
                                                else
                                                {
                                                    MessageBox.Show($"Tu calificación es {cal1}");
                                                }
                                            }
                                        }
                                    } while (exa1 > 10 || exa1 < 0);

                                }
                                if (tre1 < tr1)
                                {
                                    do
                                    {
                                        exa1 = int.Parse(Interaction.InputBox("Cuánto sacaste en el examen"));
                                        if (exa1 > 10 || exa1 < 0)
                                        {
                                            MessageBox.Show("Ingresa una califiación del 0-10");
                                        }
                                        else
                                        {
                                            cal1 = exa1;
                                            MessageBox.Show($"Tu calificación es {cal1}");
                                        }
                                    } while (exa1 > 10 || exa1 < 0);

                                }
                            }
                        } while (tre1 > tr1 || tre1 < 0);
                        break;
                    case 3:
                        do
                        {
                            tr2 = int.Parse(Interaction.InputBox("Cuántas tareas pidio el mastro"));
                            tre2 = int.Parse(Interaction.InputBox("Cuántas entregaste"));
                            if (tre2 > tr2 || tre2 < 0)
                            {
                                MessageBox.Show("No puedes entregar más tareas de las que se piden, o no puedes entregar menos de 0 tareas");
                            }
                            else
                            {
                                if (tre2 == tr2)
                                {

                                    MessageBox.Show("Tienes derecho a 2 puntos extra para tu calificación del examen");
                                    do
                                    {
                                        exa2 = int.Parse(Interaction.InputBox("Cuánto sacaste en el examen"));
                                        if (exa2 > 10 || exa2 < 0)
                                        {
                                            MessageBox.Show("Ingresa una calificación que sea del 0-10");
                                        }
                                        else
                                        {
                                            if (exa2 < 6)
                                            {
                                                cal2 = exa2;
                                                MessageBox.Show($"Tú calificación es {cal2}");
                                            }
                                            if (exa2 >= 6)
                                            {
                                                cal2 = exa2 + 2;
                                                if (cal2 > 10)
                                                {
                                                    cal2 = 10;
                                                    MessageBox.Show($"Tú calificación es {cal2}");
                                                }
                                                else
                                                {
                                                    MessageBox.Show($"Tu calificación es {cal2}");
                                                }
                                            }
                                        }
                                    } while (exa2 > 10 || exa2 < 0);

                                }
                                if (tre2 < tr2)
                                {
                                    do
                                    {
                                        exa = int.Parse(Interaction.InputBox("Cuánto sacaste en el examen"));
                                        if (exa2 > 10 || exa2 < 0)
                                        {
                                            MessageBox.Show("Ingresa una califiación del 0-10");
                                        }
                                        else
                                        {
                                            cal2 = exa2;
                                            MessageBox.Show($"Tu calificación es {cal2}");
                                        }
                                    } while (exa2 > 10 || exa2 < 0);

                                }
                            }
                        } while (tre2 > tr2 || tre2 < 0);
                        break;
                    case 4:
                        calf = (cal + cal1 + cal2) / 3;
                        MessageBox.Show($"Tu calificación es {calf}");
                        break;
                }
            } while (op != 0);
        }
    }
}
